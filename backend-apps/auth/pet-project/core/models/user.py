from typing import AsyncGenerator, TYPE_CHECKING
from fastapi_users.db import (
    SQLAlchemyBaseUserTable,
    SQLAlchemyUserDatabase,
)
from .base import Base
from .mixins.id_int_pk import IdIntPkMixin
from core.types.user_id import UserIdType
from sqlalchemy.orm import Mapped, declared_attr, mapped_column
from sqlalchemy import types, CheckConstraint, Boolean, func
from datetime import datetime

if TYPE_CHECKING:
    from sqlalchemy.ext.asyncio import AsyncSession


class User(Base, IdIntPkMixin, SQLAlchemyBaseUserTable[UserIdType]):
    name: Mapped[str] = mapped_column(
        types.String(length=50), unique=False, index=False, nullable=False
    )
    surname: Mapped[str] = mapped_column(
        types.String(length=50), unique=False, index=False, nullable=False
    )
    location: Mapped[str] = mapped_column(
        types.String(length=120), unique=False, index=False, nullable=False
    )
    phone_number: Mapped[str] = mapped_column(
        types.String(length=15), unique=False, index=False, nullable=True
    )
    created_on: Mapped[datetime] = mapped_column(
        types.DateTime(), nullable=False, default=func.now()
    )
    last_modified_on: Mapped[datetime] = mapped_column(
        types.DateTime(), nullable=False, default=func.now(), onupdate=func.now()
    )
    prefers_phone_call: Mapped[bool] = mapped_column(
        Boolean, nullable=False, default=False
    )
    prefers_telegram: Mapped[bool] = mapped_column(
        Boolean, nullable=False, default=False
    )

    @classmethod
    def get_db(cls, session: "AsyncSession"):
        return SQLAlchemyUserDatabase(session, cls)
