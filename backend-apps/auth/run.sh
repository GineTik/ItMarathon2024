python3 -m venv .env
pip install --no-cache-dir --upgrade -r requirements.txt
cd pet-project || exit
alembic upgrade head
gunicorn main:main_app
read  -n 1 -p "Input Selection:" mainmenuinput
