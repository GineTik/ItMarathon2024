"""Added new fields to User model

Revision ID: c0b3e79f1cd3
Revises: e1d2cec4488c
Create Date: 2024-08-01 17:55:07.017860

"""
from typing import Sequence, Union

from alembic import op
import sqlalchemy as sa


# revision identifiers, used by Alembic.
revision: str = 'c0b3e79f1cd3'
down_revision: Union[str, None] = 'e1d2cec4488c'
branch_labels: Union[str, Sequence[str], None] = None
depends_on: Union[str, Sequence[str], None] = None


def upgrade() -> None:
    # ### commands auto generated by Alembic - please adjust! ###
    op.add_column('users', sa.Column('name', sa.String(length=50), nullable=False))
    op.add_column('users', sa.Column('surname', sa.String(length=50), nullable=False))
    op.add_column('users', sa.Column('address', sa.String(length=120), nullable=True))
    op.add_column('users', sa.Column('phone_number', sa.String(length=15), nullable=True))
    op.add_column('users', sa.Column('created_on', sa.DateTime(), nullable=False))
    op.add_column('users', sa.Column('last_modified_on', sa.DateTime(), nullable=False))
    # ### end Alembic commands ###


def downgrade() -> None:
    # ### commands auto generated by Alembic - please adjust! ###
    op.drop_column('users', 'last_modified_on')
    op.drop_column('users', 'created_on')
    op.drop_column('users', 'phone_number')
    op.drop_column('users', 'address')
    op.drop_column('users', 'surname')
    op.drop_column('users', 'name')
    # ### end Alembic commands ###
