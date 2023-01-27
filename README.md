# OVERVIEW
A REST API which supports Creating, Reading, Updating and Deleting weather with the implementation of JWT authentication and Microsoft Identity framework to to authenticate and store user and role information respectively.  


## TECHNOLOGY USED
- .Net 6.0
- EntityFrameworkCore
- MicrosoftIdentity Framework
- JWT Authentication
- Dependency Injection
- Visual Studio 2022
- Microsoft SQL Server Management Studio


## USE PROJECT
`git clone https://github.com/Ngere-Joseph/WeatherApp` and `dotnet run --project WeatherApp`


## API DEFINITION
## AUTH
#### REGISTER 
##### [POST /](#) `api/Auth/register`


#### LOGIN
##### [POST /](#) `api/Auth/login`

#### REGISTER-ADMIN
##### [POST /](#) `api/Auth/register-admin`

## WEATHER
#### CREATE WEATHER
##### [POST /](#) `WeatherForecast`

#### GET WEATHER
##### [GET /](#) `WeatherForecast`

#### GET WEATHER BY ID
##### [GET /](#) `WeatherForecast/{Id}`

#### UPDATE WEATHER
##### [UPDATE /](#) `WeatherForecast/{Id}`

#### DELETE WEATHER
##### [DELETE /](#) `WeatherForecast/{Id}`
