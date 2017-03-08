# PostmanCourse
Un repositorio con ejemplos y material para aprender a usar Postman
Para correr el curso es necesario tener la version 1.0 de .NET core disponible en https://www.microsoft.com/net/download/core
Posteriormente, dentro del directorio de PostmanAPI correr los siguientes comandos:

```
dotnet restore
dotnet run
```

Una vez iniciado, es posible acceder a la pagina de ayuda a traves de la url [http://localhost:5000/swagger](http://localhost:5000/swagger) 

## Contents
1. What is Postman and how can it help me do my job?

2. Postman basics
  1. Installing postman  [x]
  2. Sending simple requests [x]
    * GET http://google.com
    * GET http://postmanapi.com/api/basic/simple
  3. Understanding responses [x]
    * GET http://postmanapi.com/api/basic/simplejson
    * GET http://postmanapi.com/api/basic/simplexml
  4. History & Tabs [x]
  5. Settings [x]
 
3. Advanced request/response manipulation
  1. Working with headers [x]
    * GET http://postmanapi.com/api/manipulation/echoheaders
  2. Working with cookies [x]
    * GET http://postmanapi.com/api/manipulation/echocookies
  3. Request methods [x]
    * GET localhost:5000/api/manipulation/resource/1
    * POST localhost:5000/api/manipulation/resource
    * PUT localhost:5000/api/manipulation/resource/1
    * DELETE localhost:5000/api/manipulation/resource/1
  4. Sending request parameters [x]
    * GET localhost:5000/api/manipulation/echoparameters
  5. Sending request body [x]
    * GET localhost:5000/api/manipulation/echobody
  6. Saving responses [x]
    * GET google.com
	 
4. Postman advanced
  1. Exporting/Importing a request [x]
    * GET localhost:5000/api/advanced/importexport?sampleId=10
  2. Creating a collection [x]
  3. Exporting/Importing a collection [x]
  4. Requests as code snippets [x]

5. Postman for automation 
  1. Creating an environment [x]
  2. Using variables [x]
    * GET localhost:5000/api/automation/echovariable/{{myvar}}
  3. Setting a variable for a request [x]
    * GET localhost:5000/api/automation/echovariable/{{myvar}}
  4. Extracting data from a response [x]
    * GET localhost:5000/api/automation/responsedata
  5. Chaining requests [x]
    * GET localhost:5000/api/automation/firstchained
    * GET localhost:5000/api/automation/secondchained

6. Advanced postman testing 
  1. Writing tests [x]
    * GET localhost:5000/api/testing/simpletest
    * PUT localhost:5000/api/testing/complextest/2
  2. Running a collection multiple times [x]
    * PUT localhost:5000/api/testing/randomerror
  3. Setting workflows [x]
    * GET localhost:5000/api/automation/workflowstate
    * GET localhost:5000/api/automation/firstworkflow
    * GET localhost:5000/api/automation/secondworkflow
    * GET localhost:5000/api/automation/thirdworkflow
  4. Testing examples [x] 
