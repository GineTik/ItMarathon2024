from typing import TYPE_CHECKING

from fastapi import Depends
from core.models import User, db_helper

if TYPE_CHECKING:
    from sqlalchemy.ext.asyncio import AsyncSession


async def get_users_db(
        session: "AsyncSession" = Depends(db_helper.session_getter),
):
    yield User.get_db(session=session)
