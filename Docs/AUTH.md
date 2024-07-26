## AUTH

### Register
```
POST {{host}}/auth/register
```
```json
{
  "firstName": "oni",
  "lastName": "oni",
  "email": "oni@oni.com",
  "password": "MyBigPassword"
}
```

### Register Response
```json
{
  "id": "GUID_HERE",
  "firstName": "oni",
  "lastName": "oni",
  "email": "oni@oni.com",
  "token": "TOKEN_HERE"
}
```

### Login
```
POST {{host}}/auth/login
```
```json
{
  "email": "oni@oni.com",
  "password": "MyBigPassword"
}
```

### Login Response
```json
{
  "id": "GUID_HERE",
  "firstName": "oni",
  "lastName": "oni",
  "email": "oni@oni.com",
  "token": "TOKEN_HERE"
}
```