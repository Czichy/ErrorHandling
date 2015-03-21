Examples of error handling:
* Unexpected errors - global logging and hiding exception details (FailingUserGateway.UnexpectedSqlException, SendErrorWithoutDetailsAttribute).
* Alternate use case path - discovered by business requirements analysis (unique user name).
* Expected low level errors - handled by gateway and hidden from the use case (DeadlockException).
