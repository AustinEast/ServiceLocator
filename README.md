# ServiceLocator v0.1.0
### Purpose
The aim of the scripts in this repository is to
provide a clean solution for managing growing
number of services, controllers, managers, systems.

The core functionalities are:
* Registering Services
* Retrieving Services
* Auto Registering Services 

### Usage
#### Creation of the service 
Currently only classes implementing [IServiceBase](Services/IServiceBase.cs)
interface can be registered in the service locator. The interface enforces
implementation of 3 methods:
* _void Restart()_ - logic resetting settings of the service to initial state. _Reset_ would be better name for the method, however MonoBehaviour already contains method with that name. 
* _void Enable()_ - enabling logic
* _void Disable()_ - disable logic

If your Service is extending _MonoBehaviour_ you can extend _MonoServiceBase_ abstract class instead. 
This class modifies the name of the object to match the one of the service. 

::Work In Progress::
