FROM python:3.9-slim
RUN pip install docker
COPY docker/monitor/monitor.py /app/
WORKDIR /app
ENTRYPOINT python monitor.py
