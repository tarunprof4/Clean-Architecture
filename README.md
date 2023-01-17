# Clean-Architecture .Net C#
Clean-Architecture in .Net C# 

It took me personally 3 years to exactly understand the nuances of this architecture primarly because the internet has multiple variations of this architecture. Most of the narrations i came across are right from their presepective
but these many variations let me to confusion. So here is an attempt to demonstate clean architecture in clear and concise way

Mandatory Prerequisites: Loosely Coupled System 
https://github.com/tarunprof4/NLayerArchitecture-LooselyCoupled

Brief History- It started with N layer architecture which got refined to ports and adaptors/Hexagonal architecture which further got refined to
onion architecture and which finally got refined to clean architecture. Given today the final refined architecture is clean architecture.
So if you hear any of the names mentioned above, you can assume all point to same thing from design principles.
Also at many places domain driven design is mixed with clean architecture. In practical this makes sense but for this repository
the focus will entirely be on clean architecture. 


Diagram:
I found it tough in the beginning to understand concentric circles representation, so sharing below different representation

![CleanArchitecture (1)](https://user-images.githubusercontent.com/116249623/212561223-b632ca38-9f8b-46a0-ab7e-e54871eb8ab9.jpg)

RegisterCustomerController with Post method- Register customer request.
Added swagger to hit the same.
Swagger url - http://localhost:14499/swagger/index.html


Clean Architecture Folder structure
1) Presentation Library - Self explantory, entry and exit point for the request
2) Application Library - this should contain logic as a workflow to complete the request. For eg here first the request makes a call in domain library
to check if the customer is allowed to register. If allowed then it calls repository layer. This layer DOESNT contain actual domain logic.
Note: For eg. CanCustomerRegister() method is written in domain layer and not in Application layer and THIS DISTINCTION is very important.
3) Domain - this layer contains real domain logic(also called use cases) around which the software is built. 
4) Infrastructure folder has 2 class libraries - under infrasturce comes connection to EXTERNAL SYSTEMS like database, sending emails, sending sms
etc.
a) Repository - Self explantory, used to persist the data
b) SendEmail - Self explantory, used to send emails
5) Shared Kernel - in this layer all common wrappers are written which are then required by all above mentioned class libraries
6) Tests - Self explantory, tests for each layer


As this is a sample repository, for detailed proper implementation please refer to below link:
https://github.com/tarunprof4/Bookmyslot-Api/tree/CleanArchitectureWithDDD
LoginController SocialCustomerLogin method

