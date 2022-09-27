# EmployeeSchdule
EmployeeSchdule For Albaruni demo Test
PROBLEM STATEMENT:
The challenge was to retrieve this raw schedule from the database and return it as a flat schedule as response from an API call.
What i did
1-	Implemented swagger for testing.
2-	Implemented overlapping according to 'Time Interval' 
3-	Implemented validation for a flat schedule that a leave doesn't not exceed the beginning or ending of a shift.
4-  Also Added Script for Db in DbScript Folder with Seeding Data
QUESTIONS:
Q1 How long did you spend on this assignment? What would you have done different if you had more time?
Ans:  Spent 3 hours on it
Q 2 What are focus areas if your code would have to be part of an actual application?
Focus on Following 
1. Optimize code and performance
2. Readable and Useable code
3. Reduce code minimize

How to Run

1. Clone form git
2. Run Script for database and seeded data ( Script is in DBScript folder)
3. Open solution and run with F5 or run with click in VS
4. Swagger opened and put the Employee Id 1,2 or 3 to check response

OUTOUT for Employee ID 1
[
  {
    "Key": "Shift",
    "Value": {
      "StartTime": "09:00:00",
      "EndTime": "12:00:00"
    }
  },
  {
    "Key": "Break",
    "Value": {
      "StartTime": "12:00:00",
      "EndTime": "13:00:00"
    }
  },
  {
    "Key": "Shift",
    "Value": {
      "StartTime": "13:00:00",
      "EndTime": "15:00:00"
    }
  },
  {
    "Key": "Break",
    "Value": {
      "StartTime": "15:00:00",
      "EndTime": "16:00:00"
    }
  },
  {
    "Key": "Leave",
    "Value": {
      "StartTime": "16:00:00",
      "EndTime": "18:00:00"
    }
  }
]

For EmployeeID 2 

[
  {
    "Key": "Shift",
    "Value": {
      "StartTime": "12:00:00",
      "EndTime": "17:00:00"
    }
  },
  {
    "Key": "Break",
    "Value": {
      "StartTime": "17:00:00",
      "EndTime": "18:00:00"
    }
  },
  {
    "Key": "Leave",
    "Value": {
      "StartTime": "18:00:00",
      "EndTime": "20:00:00"
    }
  }
]

[
  {
    "Key": "Shift",
    "Value": {
      "StartTime": "09:00:00",
      "EndTime": "12:00:00"
    }
  },
  {
    "Key": "Break",
    "Value": {
      "StartTime": "12:00:00",
      "EndTime": "13:00:00"
    }
  },
  {
    "Key": "Shift",
    "Value": {
      "StartTime": "13:00:00",
      "EndTime": "18:00:00"
    }
  }
]
