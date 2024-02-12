1. Öncelikle go mod init ile paket oluşturalım.
> go mod init btkakademi.gov.tr/webservices

2. Klasör yapısı 

> greet
> greet/client
> greet/server
> greet/proto 

3. proto dosyasının oluşturulması 

```
syntax ="proto3";
package greet;

option go_package = "btkakademi.gov.tr/webservices/greet/proto";

message GreetRequest {
    string first_name = 1;
  }
  
  message GreetResponse {
    string result = 1;
  }

  service GreetService {
    rpc Greet(GreetRequest) returns (GreetResponse);
  }
```

4. Protocol bufffers ve gRPC servis tanımlarının üretilmesi 

protoc -Igreet/proto --go_out=. --go_opt=module=btkakademi.gov.tr/webservices --go-grpc_out=. --go-grpc_opt=module=btkakademi.gov.tr/webservices greet/proto/greet.proto

5. Sunucu tarafı için go script'nin yazılması

6. İstemci tarafı için go script'nin yazılması

7. Sunucu script ikili kodlarının oluşturulması 

> go build -o bin/greet/server/main.exe greet/server/main.go

> go build -o bin/greet/client/main.exe greet/client/main.go