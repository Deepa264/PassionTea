@Tea
Feature:PassionTea
As a customer 
When i should place an order for different types of tea
I should be able to place an order and submit the feedback

Background: 
Given I will go to passion tea homepage

Scenario: Welcome  Homepage
Then i see passion tea homepage

Scenario: place an order for Green tea with Mastercard
Given I will open Herbal tea collections
When I select Green Tea and place an order
Then I see a order confirmation page

Scenario: place an order for Oolang tea with VisaCard
Given I will open Loose tea collections
When I select Oolang tea and place an order
Then I see a order confirmation page

Scenario:Feedback should be submitted to the passion tea Company
Given I will go the Let's talk Tea page
When I willcomplete the feedback form
Then I can submit the form and get confirmation



