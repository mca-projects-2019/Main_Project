from pymongo import MongoClient
from pprint import pprint


client = MongoClient()
db=client.test


student = db.student
student_details = {
    'Name': 'Raj Kumar',
    'Address': 'ABC HOUSE, House No:32',
    'Age': '21'
}

#insert method
result = student.insert_one(student_details)

# Query for the inserted document.
Queryresult = student.find_one({'Age': '21'})
print(Queryresult)