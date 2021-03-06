using HotChocolate.Types;

namespace Demo.Contracts
{
    public class QueryType
        : ObjectType<Query>
    {
        protected override void Configure(
            IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetContract(default))
                .Argument("contractId", a => a.Type<NonNullType<IdType>>())
                .Type<ContractType>();

            descriptor.Field(t => t.GetContracts(default))
                .Argument("customerId", a => a.Type<NonNullType<IdType>>())
                .Type<ListType<NonNullType<ContractType>>>();
        }
    }
}
