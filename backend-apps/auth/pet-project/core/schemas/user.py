from fastapi_users import schemas

from core.types.user_id import UserIdType
from datetime import datetime
from pydantic import BaseModel


class UserRead(schemas.BaseUser[UserIdType]):
    name: str
    surname: str
    location: str
    phone_number: str | None = None
    created_on: datetime
    last_modified_on: datetime
    is_active: bool
    prefers_phone_call: bool
    prefers_telegram: bool


class UserCreate(schemas.BaseUserCreate):
    name: str
    surname: str
    location: str


class UserUpdate(schemas.BaseUserUpdate):
    location: str
    phone_number: str | None = None


class UserConfirmation(BaseModel):
    email: str
