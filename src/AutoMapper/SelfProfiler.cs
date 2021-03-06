namespace AutoMapper
{
	public abstract class SelfProfiler<TSource, TDestination> : Profile, ISelfProfiler
	{
		protected internal override void Configure()
		{
			IMappingExpression<TSource, TDestination> mappingExpression = CreateMap<TSource, TDestination>();
			DescribeConfiguration(mappingExpression);
		}

		protected abstract void DescribeConfiguration(IMappingExpression<TSource, TDestination> map);

		public Profile GetProfile()
		{
			return this;
		}
	}
}
