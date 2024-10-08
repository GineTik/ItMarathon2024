import smtplib
import os
from typing import List
from email.mime.text import MIMEText
from email.mime.multipart import MIMEMultipart
from jinja2 import Environment, FileSystemLoader
from azure.communication.email import EmailClient

class MailSenderHelper:
    def __init__(self, sender) -> None:
        self.smtp_server = os.environ.get("SMTP_HOST")
        self.smtp_port = os.environ.get("SMTP_PORT")
        self.smtp_username = os.environ.get("SMTP_USERNAME")
        self.smtp_password = os.environ.get("SMTP_PASSWORD")
        self.smtp_connectionString = os.environ.get("APP_CONFIG__EMAIL_CONNECTION_STRING")
        self.sender = sender

    def send_email(self, email, topic, body):
        # MIME object
        msg = MIMEMultipart()
        msg["From"] = self.sender
        msg["To"] = email
        msg["Subject"] = topic

        msg.attach(MIMEText(body, "html"))

        with smtplib.SMTP(self.smtp_server, self.smtp_port) as server:
            server.starttls()
            server.login(self.smtp_username, self.smtp_password)
            server.sendmail(self.smtp_username, email, msg.as_string())

    def send_email_SMTP(self, email, topic, body):
        try:
            connection_string = self.smtp_connectionString
            client = EmailClient.from_connection_string(connection_string)
    
            message = {
                "senderAddress": "DoNotReply@45243aed-4cc9-4651-8a8f-e146b6f6036b.azurecomm.net",
                "recipients":  {
                    "to": [{"address": email }],
                },
                "content": {
                    "subject": topic,
                    "html": body,
                }
            }
    
            poller = client.begin_send(message)
            result = poller.result()
 
        except Exception as ex:
            print(ex)