As per OpenApi specifications route parameters are by default assumed to be required and non-nullable, if there 
are design considerations in your application which needs optional route parameters,use the below steps

1. Create a Attribute which targets the routes which need to adapt this behaviour. you need not have this if you want the behaviour
   to be targeted for all controller methods.for example refer to SwaggerOptionalRouteParamAttribute.cs file inside SwaggerExtensions
2. we can override route attribute behaviours by extending IOperationFilter of SwaggerGen. In this mechanism we look at the          operationfiltercontext of swashbuckle and override the openapioperation parameters to reflect the nullability of a paramter
3. In the AddSwaggerGen Options add the OperationFilter like this
   options.OperationFilter<OverrideOptionalRouteParamFilter>();
