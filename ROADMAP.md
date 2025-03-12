# ASP.NET Clean Architecture Project Checklist

## 1. Khởi tạo một dự án asp.net web api theo mô hình Clean Architecture.
#### Action:
- [ ] Tạo dự án ASP.NET Web API với Clean Architecture

#### Kiến thức thu được:
- [ ] Hiểu về C# cơ bản (OOP, Collections, LINQ, Async/Await).
- [ ] Cấu trúc một Web API trong ASP.NET Core.
- [ ] Khái niệm về Controller, Services, Dependency Injection (DI).
- [ ] Kiến trúc xây dựng một dự án (N-Layer, Onion, Clean Architecture, ...).

## 2. Làm việc với Database:

### 2.1.Domain Layer:
#### Action:
- [ ] Tạo entities, IRepository, IUnitOfWork, IDapperExecutor.

#### Kiến thức thu được:
- [ ] Nắm được các kiến thức cơ bản về abtract class, interface, override, generic.

### 2.2.Persistence Layer:
#### Action:
- [ ] Tạo Dbcontext, cấu hình config cho các entities(Fluent API, Data Annotations - Decorator pattern).
- [ ] Cấu hình các Repositories
- [ ] Xây dựng UnitOfWork
- [ ] Migration database

#### Kiến thức thu được:
- [ ] Kết nối và làm việc với csdl thông qua EFCore, Dapper, Migration.
- [ ] Hiểu rõ và cách xây dựng Dbcontext, transaction, Repository pattern, UnitOfWork.

### 2.3.Application:
#### Action:
- [ ] Tạo các interface Repositories cho từng bảng cụ thể.

## 3. CQRS + event(MediatR):

### Action:
- [ ] Tạo các interfaces cần thiết:
    - Domain layer: IDomainEvent, IDomainEventHandler
    - Application layer: IQuery, IQueryHandler, ICommand, ICommandHandler, IDispatch
- [ ] Infrastructure layer:
    - Cài đặt và triển khai MediatR

### Kiến thức thu được:
- [ ] Nắm được cách hoạt động và triển khai message bus, event bus.

## 4. Xử lý Respone, Exception, Middleware:

### Domain layer:
#### Action:
- [ ] Tạo các abstract class: Result, PageResult, Error
- [ ] Sử dụng Middleware triển khai các cấu hình đã tạo

### Kiến thức thu được:
- [ ] Nắm được cách quản lý và xử lý kết quả trả về.

## 5. Dựng background job (Hangfire, IHost, Redis):

### Application:
#### Action:
- [ ] Tạo các interface service để quản lý job: IBackgroundJobService

### Infrastructure:
#### Action:
- [ ] Cài đặt Hangfire, và triển khai các chức năng đã đăng ký tại IBackgroundJobService.
- [ ] DI Hangfire vào dự án.

### Kiến thức thu được:
- [ ] Xây dựng một background job service để xử lý các công việc chạy ngầm cho dự án.

## 6. Caching, Logging

### Action:
- [ ] Cài đặt và sử dụng Redis Cache thông qua IDistributedCache
- [ ] Tạo Repositories cache.
- [ ] Cấu hình logging với Serilog.

### Kiến thức thu được:
- [ ] Học được cách làm việc và xử lý cache.
- [ ] Cấu hình logging.

## 7. Authentication, Authorization

### Action:
- [ ] Viết api xử lý Authentication, trả về thông tin xác thực.
- [ ] Sử dụng attributes để xử lý Authorization.

### Kiến thức thu được:
- [ ] Học được cách xử lý cơ bản về Authentication, Authorization.

## 8. Notification

### Action:
- [ ] Xây dựng Notification cho hệ thống bằng SignalR.

### Kiến thức thu được:
- [ ] Làm việc với thư viện SignalR, websocket.