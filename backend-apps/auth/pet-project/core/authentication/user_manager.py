import os
import base64
import logging
from typing import Optional, TYPE_CHECKING

from fastapi_users import BaseUserManager, IntegerIDMixin
from azure.storage.blob import BlobClient
from jinja2 import Environment, FileSystemLoader

from core.config import settings
from core.models import User
from core.types.user_id import UserIdType
from core.helpers.email_verification import MailSenderHelper

if TYPE_CHECKING:
    from fastapi import Request

log = logging.getLogger(__name__)

CONNECTION_STRING = os.getenv("AzureBlobStorageConfig__ConnectionString")
CONTAINER_NAME = "itmarathoncontainer"


# Function to read image and convert to base64
def read_image_to_base64(blob_name):
    blob_client = BlobClient.from_connection_string(
        conn_str=CONNECTION_STRING,
        container_name=CONTAINER_NAME,
        blob_name=blob_name,
    )
    image_data = blob_client.download_blob().readall()
    base64_encoded_image = base64.b64encode(image_data).decode("utf-8")
    return base64_encoded_image


class UserManager(IntegerIDMixin, BaseUserManager[User, UserIdType]):
    reset_password_token_secret = settings.access_token.reset_password_token_secret
    verification_token_secret = settings.access_token.verification_token_secret

    async def on_after_register(
        self,
        user: User,
        request: Optional["Request"] = None,
    ):

        pass

    # async def on_after_forgot_password(
    #     self, user: User, token: str, request: Optional["Request"] = None
    # ):
    #     log.warning(
    #         "User %r has forgotten their password. Reset token: %r",
    #         user.id,
    #         token,
    #     )
    async def on_after_login(self, user, request, response):
        pass

    async def on_after_request_verify(
        self, user: User, token: str, request: Optional["Request"] = None
    ):
        log.warning(
            "Verification requested for user %r. Verification token: %r",
            user.id,
            token,
        )

        # Get template
        env = Environment(loader=FileSystemLoader("templates"))
        template = env.get_template("index.html")
        footer_logo = read_image_to_base64("footer-logo.png")
        header_logo = read_image_to_base64("header-logo.png")

        log.warning("footer_logo: %r", footer_logo)

        # Render template
        html_content = template.render(
            user_name=user.name,
            verification_token=token,
            footer_logo=footer_logo,
            header_logo=header_logo,
        )
        # log.warning("User %r has registered.", user.id)
        mail_sender = MailSenderHelper("http://petworld.com")
        mail_sender.send_email_SMTP(
            email=user.email, topic="Your verification link", body=html_content
        )

    async def on_after_verify(self, user: User, request: Optional["Request"] = None):
        print(f"User {user.id} has been verified")
