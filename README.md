# FitnessTrack

This application is built as a microservices architecture consisting of 9 containers.

- One container for the frontend
- 4 containers, each an API based on business logic (workouts, meals, measurements, dashboard)
- 3 containers hosting the databases (workoute, meals, measurement)
- 1 redis cache for the dashboard API calls

## Running the application

_Requires docker compose to be installed_

To run the application:

```bash
docker compose up
```

_Please note that the frontend might not function as expected, as it relies on Azure AD B2C, which has been deleted by cancelling the subscription which was provided by Univeristy of Surrey._
However, the APIs should be accessible for testing on their localhost:<api-port>/swagger (check docker-compose.yml file for ports)
