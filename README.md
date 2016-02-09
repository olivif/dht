# DHT

An implementation of a [DHT](https://en.wikipedia.org/wiki/Distributed_hash_table) just for fun.

## Project structure
    +---DHT            -> root
    |   +---DHT        -> dev 
    |   +---DHT.Tests  -> tests
    
## Basic DHT concepts explained

### Data
This is a basic piece of data that will be stored in the DHT.

### Node 
Every node is able to store and index multiple pieces of data. It should also be able to find the correct node to relay the content to according to the key space.

### Hasher
The hasher is responsible for creating a hash value out of the piece of data provided.


    
