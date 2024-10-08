from fastapi_users import FastAPIUsers

from core.types.user_id import UserIdType
from core.models import User
from api.dependencies.authentication.user_manager import get_user_manager
from api.dependencies.authentication.backend import authentication_backend

fastapi_users_router = FastAPIUsers[User, UserIdType](
    get_user_manager, [authentication_backend]
)