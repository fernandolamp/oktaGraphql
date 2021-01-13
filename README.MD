# Simple Graphql using HotChocolate and Okta authorization

This code was based on the tutorial:

https://developer.okta.com/blog/2020/08/24/simple-graphql-csharp

This tutorial is old, the code here was updated based on the chillicream docs:

https://chillicream.com/docs/hotchocolate/integrations/entity-framework

## How to run the code?

Override the configuration variable on "appSettings.json" with your okta domain.

Just compile and run the code, get the authorization token and do a request to graphql.

To understand how to create a domain and get token to do request, please read the okta tutorial.