# IO.Swagger - ASP.NET Core 2.0 Server

API access to Moody's Analytics repository of international and subnational economic and demographic time series data.  To acquire your client_id and client_secret, visit [https://www.economy.com/myeconomy/api-key-info](https://www.economy.com/myeconomy/api-key-info).  If you are not registered, you can register for a free account to retrieve your keys  For more info, see the [documentation](https://github.com/moodysanalytics/databuffet.api.codesamples/blob/master/dataBuffet-api-userguide.md#retrieve-a-single-series) 

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
