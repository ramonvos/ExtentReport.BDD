# Using ExtentReport with BDD Specflow


## Setup:

1. Clone repository;

2. Build solution;

3. Run Test


## Reporter Architecture:

 * Reporter.InitializeReport-> Create report instance
 * Reporter.AddFeature -> Add Scenario/Test Name node
 * Reporter.AddLogSteps -> Add Scenario/Test Name steps info
 * Reporter.GenerateReport -> Close report instance and generate report



## Example:

* Open index.html file in /bin folder:

Tests tab:
![Image](https://i.ibb.co/QbtdN6v/Imagem-1.png)

Tags tab:
![Image](https://i.ibb.co/9mP5vNT/Imagem-2.png)

Dashboard tab:
![Image](https://i.ibb.co/F5HcQ51/Imagem-3.png)

