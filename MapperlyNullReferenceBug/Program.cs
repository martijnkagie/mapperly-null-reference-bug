using MapperlyNullReferenceBug;

var source = new Foo
{
    Property1 = null,
    Property2 = 1,
};

var destination = Mapper.ToDto(source); //A NullReferenceException is thrown
