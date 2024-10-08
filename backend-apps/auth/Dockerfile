FROM python:3.11-slim

COPY pet-project ./
WORKDIR /pet-project
COPY requirements.txt ./
RUN pip install --no-cache-dir --upgrade -r requirements.txt
EXPOSE 8000
CMD ["gunicorn", "main:main_app"]