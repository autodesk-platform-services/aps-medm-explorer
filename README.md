# APS M&E Data Model Explorer

The sample is using this [GraphiQL project](https://github.com/graphql/graphiql) that makes it really easy to discover the M&E Data Model API through GraphQL calls.

# Thumbnail

![Thumbnail](./thumbnail.png)

## Setting up the app

- clone this repository or download it
- restore the packages
- replace the variable values at appsettings.Development.json with your own

```json
{
  "APS_CLIENT_ID": "YOUR CLIENT ID",
  "APS_CLIENT_SECRET": "YOUR CLIENT SECRET",
  "APS_CALLBACK_URL": "http://localhost:8080/api/auth/callback"
}
```

**Make sure your APS app also uses the same callback url!**

## Running the app

As instructed in the console, you'll need to open a web browser and navigate to http://localhost:8080 in order to log into your Autodesk account

## Output

Once you logged in with your Autodesk account in the browser, this should appear:

![GraphiQL](./readme/GraphiQL.png)

This sample comes by default with the step-by-step tutorial queries in multiple tabs. You can run the queries available in these tabs and add your own.

You can also check the documentation:

![Docs](./readme/Docs.png)




---

## Tips & Tricks

You can also see the schema in a nice way using [GraphQL Voyager](https://graphql-kit.com/graphql-voyager/):

![Docs](./readme/voyager.png)


## Written and updated by

- Denis Grigor  [Developer Advocate and Support](http://aps.autodesk.com)
