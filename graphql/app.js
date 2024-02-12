import express from 'express';
import users from './schema/data.js';
import { graphqlHTTP } from 'express-graphql';
import { schema } from './schema/schema.js';

const app = express();

app.use("/graphql", graphqlHTTP({
    schema: schema,
    graphiql: true
}));

app.get("/rest", (req, res) =>
{
    res.send(users);
});

app.listen(3000);