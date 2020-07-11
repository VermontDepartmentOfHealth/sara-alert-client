# Sara Alert

## Setup


### Files

#### appsecrets.json

```json
{
  "ClientId": "***",
  "ClientSecret": "***",
  /* expires every two hours - must be re-quired via MFA workflow */
  "AuthorizationCode": "***"
}
```

#### apptoken.json

```json
{
  "AccessToken": "*",
  "TokenType": "*",
  "Scope": "*",
  "ExpiresInd": "*",
  "CreatedAt":  "*"
}
```



## Resources

* [Sara Alert API](https://github.com/SaraAlert/SaraAlert/blob/master/API.md)
* Implements FHIR version R4
* [Sara Alert - Training](https://www.youtube.com/watch?v=R52VMSxqz3g)
  * [Playlist](https://www.youtube.com/watch?v=zyHefjOL0eM&list=PLkTApXQou_8KbzQBhp5Y8a_jbO2WsXaZe)

### FHIR

* **FHIR** (Fast Healthcare Interoperability Resources)
* [Spec for Patient](https://www.hl7.org/fhir/patient.html)
  * [HumanName](https://www.hl7.org/fhir/datatypes.html#HumanName)
  * [Address](https://www.hl7.org/fhir/datatypes.html#Address)
* [Public Servers for Testing](https://confluence.hl7.org/display/FHIR/Public+Test+Servers)
  * http://test.fhir.org/r4
  * https://vonk.fire.ly/r4

### .NET Client

* [.NET Client - Firefly](https://github.com/FirelyTeam/fhir-net-api)
* [nuget - Hl7.Fhir.R4](https://www.nuget.org/packages/Hl7.Fhir.R4)
* [online docs](http://docs.simplifier.net/fhirnetapi/index.html)
  * [Authorization](http://docs.simplifier.net/vonk/features/accesscontrol.html#authorization)
  * [Model Classes](http://docs.simplifier.net/fhirnetapi/model/classes.html)
  * [FhirClient](http://docs.simplifier.net/fhirnetapi/client/setup.html)
  * [CRUD Interactions](http://docs.simplifier.net/fhirnetapi/client/crud.html)


