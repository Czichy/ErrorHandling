Examples of error handling:
1. Unexpected errors - global logging and hiding exception details (FailingUserGateway.UnexpectedSqlException, SendErrorWithoutDetailsAttribute).
2. Alternate use case path - discovered by business requirements analysis (unique user name).
3. Expected low level errors - handled by gateway and hidden from the use case (DeadlockException).
