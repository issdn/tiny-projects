from client import Client
from database import Database

db = Database()
client = Client(database=db)
