using Bricks.RuntimeFramework;
using Repository;
using NUnit.Framework;
using Rhino.Mocks;
using White.Core.UIItems.WindowItems;

namespace White.Repository.UnitTests
{
    [TestFixture]
    public class ScreenClassTest
    {
        [Test]
        public void NewScreenContainingComponent()
        {
            var mocks = new MockRepository();
            var window = mocks.CreateMock<Window>();
            var screenRepository = mocks.CreateMock<ScreenRepository>();
            mocks.ReplayAll();
            var @class = new Class(typeof(ScreenClassContainingComponent));
            new ScreenClass(@class).New(window, screenRepository);
        }
    }

    public class ScreenClassContainingComponent : AppScreen
    {
        private ScreenClassComponent screenClassComponent;
        public ScreenClassContainingComponent(Window window, ScreenRepository screenRepository) : base(window, screenRepository) {}
    }

    public class ScreenClassComponent : AppScreenComponent
    {
        public ScreenClassComponent(Window window, ScreenRepository screenRepository) : base(window, screenRepository) {}
    }
}