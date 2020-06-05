
##### Description:
```
Displays first 100 numbers in fibonacci sequence
```
---
Requirements
```
dotnet core 2.2
```
Usage
```bash
cd app
dotnet run
dotnet publish -c Release

```
Containerization
```bash
cd app
docker build -t <custom_image_name>:<tag> .
docker run --name <custom_app_name> <custom_iamge_name>:<tag>


