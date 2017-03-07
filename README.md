# PostmanCourse
Un repositorio con ejemplos y material para aprender a usar Postman

## Contents
1. What is Postman and how can it help me do my job?

2. Postman basics
 1. Installing postman  [x]
 2. Sending simple requests [x]
	a. GET http://google.com
	b. GET http://postmanapi.com/api/basic/simple
 3. Understanding responses [x]
	a. GET http://postmanapi.com/api/basic/simplejson
	b. GET http://postmanapi.com/api/basic/simplexml
 4. History & Tabs [x]
 5. Settings [x]
 
3. Advanced request/response manipulation
 1. Working with headers [x]
	a. GET http://postmanapi.com/api/manipulation/echoheaders
 2. Working with cookies [x]
 	a. GET http://postmanapi.com/api/manipulation/echocookies
 3. Request methods [x]
 	a. GET localhost:5000/api/manipulation/resource/1
	b. POST localhost:5000/api/manipulation/resource
	c. PUT localhost:5000/api/manipulation/resource/1
	d. DELETE localhost:5000/api/manipulation/resource/1
 4. Sending request parameters [x]
 	a. GET localhost:5000/api/manipulation/echoparameters
 5. Sending request body [x]
 	a. GET localhost:5000/api/manipulation/echobody
 6. Saving responses [x]
 	a. GET google.com
	 
4. Postman advanced
 1. Exporting/Importing a request [x]
 	a. GET localhost:5000/api/advanced/importexport?sampleId=10
 2. Creating a collection [x]
 3. Exporting/Importing a collection [x]
 4. Requests as code snippets [x]

5. Postman for automation 
 1. Creating an environment [x]
 2. Using variables [x]
 	a. GET localhost:5000/api/automation/echovariable/{{myvar}}
 3. Setting a variable for a request [x]
 	a. GET localhost:5000/api/automation/echovariable/{{myvar}}
 4. Extracting data from a response [x]
 	a. GET localhost:5000/api/automation/responsedata
 5. Chaining requests [x]
 	a. GET localhost:5000/api/automation/firstchained
	b. GET localhost:5000/api/automation/secondchained

6. Advanced postman testing 
 1. Writing tests [x]
 	a. GET localhost:5000/api/testing/simpletest
	b. PUT localhost:5000/api/testing/complextest/2
 2. Running a collection multiple times [x]
 	b. PUT localhost:5000/api/testing/randomerror
 3. Setting workflows [x]
 	a. GET localhost:5000/api/automation/workflowstate
	b. GET localhost:5000/api/automation/firstworkflow
	b. GET localhost:5000/api/automation/secondworkflow
	b. GET localhost:5000/api/automation/thirdworkflow
 4. Testing examples [x]
 