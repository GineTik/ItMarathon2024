from fastapi import APIRouter

from api.v1.fastapi_users_router import fastapi_users_router
from core.config import settings
from core.schemas.user import UserRead, UserUpdate

router = APIRouter(
    prefix=settings.api.users,
    tags=["Users"],
)

# /me
# /{id}
router.include_router(
    router=fastapi_users_router.get_users_router(UserRead, UserUpdate),
)
