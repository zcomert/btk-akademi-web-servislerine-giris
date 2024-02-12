protoc -Igreet/proto --go_out=. --go_opt=module=btkakademi.gov.tr/webservices --go-grpc_out=. --go-grpc_opt=module=btkakademi.gov.tr/webservices greet/proto/greet.proto
go build -o bin/greet/client/main.exe greet/client/main.go
go build -o bin/greet/server/main.exe greet/server/main.go