using SimplifierSoftware.DuplicateTabHandler;

namespace DuplicateTabHandler_UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class TabTests
    {
        private Tab _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new Tab();;
        }

        [Test]
        public void ExpandTabNameWith_MoreDirectoriesInFullyJustifiedFileName_ReturnsTrue()
        {
            _sut.VisibleTabName = "TestFile.cs";
            _sut.FullyJustifiedFileName = @"C:\TestFile.cs";

            var result = _sut.ExpandTabName();

            Assert.That(result, Is.True);
        } 

        [Test]
        public void ExpandTabNameWith_DirectoriesInFullyJustifiedFileNameAndNoneInVisibleTabName_AddsDirectroyToTabName()
        {
            _sut.VisibleTabName = "TestFile.cs";
            _sut.FullyJustifiedFileName = @"C:\TestFile.cs";

            _sut.ExpandTabName();

            Assert.That(_sut.VisibleTabName, Is.EqualTo(@"C:\TestFile.cs"));
        }

        [Test]
        public void ExpandTabNameWith_MoreDirectoriesInFullyJustifiedFileName_AddsDirectroyToTabName()
        {
            _sut.VisibleTabName = @"TestFiles\TestFile.cs";
            _sut.FullyJustifiedFileName = @"C:\TestFiles\TestFile.cs";

            _sut.ExpandTabName();

            Assert.That(_sut.VisibleTabName, Is.EqualTo(@"C:\TestFiles\TestFile.cs"));
        }

        [Test]
        public void ExpandTabNameWith_NoMoreDirectoriesInFullyJustifiedFileName_ReturnsFalse()
        {
            _sut.VisibleTabName = @"C:\TestFiles\TestFile.cs";
            _sut.FullyJustifiedFileName = @"C:\TestFiles\TestFile.cs";

            var result = _sut.ExpandTabName();

            Assert.That(result, Is.False);
        } 
    }
}
