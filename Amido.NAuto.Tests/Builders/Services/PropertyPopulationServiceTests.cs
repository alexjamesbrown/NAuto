﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Amido.NAuto.Builders;
using Amido.NAuto.Builders.Services;
using Amido.NAuto.UnitTests.Helpers;
using Moq;
using NUnit.Framework;
using Should;

namespace Amido.NAuto.UnitTests.Builders.Services
{
    [TestFixture]
    public class PropertyPopulationServiceTests
    {
        private PropertyPopulationService propertyPopulationService;
        private Mock<PopulateProperty<string>> populateStringService;
        private Mock<PopulateProperty<int>> populateIntService;
        private Mock<PopulateProperty<int?>> populateNullableIntService;
        private Mock<PopulateProperty<double>> populateDoubleService;
        private Mock<PopulateProperty<double?>> populateNullableDoubleService;
        private Mock<PopulateProperty<bool>> populateBoolService;
        private Mock<PopulateProperty<bool?>> populateNullableBoolService;
        private Mock<PopulateProperty<byte>> populateByteService;
        private Mock<PopulateProperty<byte?>> populateNullableByteService;
        private Mock<PopulateProperty<DateTime>> populateDateTimeService;
        private Mock<PopulateProperty<DateTime?>> populateNullableDateTimeService;
        private Mock<PopulateProperty<Uri>> populateUriService;
        private Mock<PopulateProperty<Guid>> populateGuidService;
        private Mock<PopulateProperty<long>> populateLongService;
        private Mock<PopulateProperty<long?>> populateNullableLongService;
        private Mock<PopulateProperty<short>> populateShortService;
        private Mock<PopulateProperty<char>> populateCharService;
        private Mock<PopulateProperty<char?>> populateNullableCharService;
        private Mock<PopulateProperty<decimal>> populateDecimalService;
        private Mock<PopulateProperty<decimal?>> populateNullableDecimalService;
        private Mock<IPopulateEnumService> populateEnumService;
        private Mock<IBuildConstructorParametersService> buildConstructorParameterService;
        private Mock<IPopulateComplexObjectService> populateComplexObjectService;
        private Mock<IPopulateListService> populateListService;
        private Mock<IPopulateDictionaryService> populateDictionaryService;
        private Mock<IPopulateArrayService> populateArrayService;
        private AutoBuilderConfiguration autoBuilderConfiguration;

        [SetUp]
        public void SetUp()
        {
            autoBuilderConfiguration = new AutoBuilderConfiguration();
            populateStringService = new Mock<PopulateProperty<string>>();
            populateIntService = new Mock<PopulateProperty<int>>();
            populateNullableIntService = new Mock<PopulateProperty<int?>>();
            populateDoubleService = new Mock<PopulateProperty<double>>();
            populateNullableDoubleService = new Mock<PopulateProperty<double?>>();
            populateBoolService = new Mock<PopulateProperty<bool>>();
            populateNullableBoolService = new Mock<PopulateProperty<bool?>>();
            populateByteService = new Mock<PopulateProperty<byte>>();
            populateNullableByteService = new Mock<PopulateProperty<byte?>>();
            populateDateTimeService = new Mock<PopulateProperty<DateTime>>();
            populateNullableDateTimeService = new Mock<PopulateProperty<DateTime?>>();
            populateUriService = new Mock<PopulateProperty<Uri>>();
            populateGuidService = new Mock<PopulateProperty<Guid>>();
            populateLongService = new Mock<PopulateProperty<long>>();
            populateNullableLongService = new Mock<PopulateProperty<long?>>();
            populateShortService = new Mock<PopulateProperty<short>>();
            populateCharService = new Mock<PopulateProperty<char>>();
            populateNullableCharService = new Mock<PopulateProperty<char?>>();
            populateDecimalService = new Mock<PopulateProperty<decimal>>();
            populateNullableDecimalService = new Mock<PopulateProperty<decimal?>>();
            populateEnumService = new Mock<IPopulateEnumService>();
            buildConstructorParameterService = new Mock<IBuildConstructorParametersService>();
            populateComplexObjectService = new Mock<IPopulateComplexObjectService>();
            populateListService = new Mock<IPopulateListService>();
            populateDictionaryService = new Mock<IPopulateDictionaryService>();
            populateArrayService = new Mock<IPopulateArrayService>();

            propertyPopulationService = new PropertyPopulationService(
                populateStringService.Object,
                populateIntService.Object,
                populateNullableIntService.Object,
                populateDoubleService.Object,
                populateNullableDoubleService.Object,
                populateBoolService.Object,
                populateNullableBoolService.Object,
                populateByteService.Object,
                populateNullableByteService.Object,
                populateDateTimeService.Object,
                populateNullableDateTimeService.Object,
                populateUriService.Object,
                populateGuidService.Object,
                populateLongService.Object,
                populateNullableLongService.Object,
                populateShortService.Object,
                populateCharService.Object,
                populateNullableCharService.Object,
                populateDecimalService.Object,
                populateNullableDecimalService.Object,
                populateEnumService.Object,
                buildConstructorParameterService.Object,
                populateComplexObjectService.Object,
                populateListService.Object,
                populateDictionaryService.Object,
                populateArrayService.Object);

            propertyPopulationService.AddConfiguration(autoBuilderConfiguration);
        }

        public class PopulateProperties : PropertyPopulationServiceTests
        {
            private class StringTest
            {
                public string Test { get; set; }
            }

            private class IntTest
            {
                public int Test { get; set; }
            }

            private class NullableIntTest
            {
                public int? Test { get; set; }
            }

            private class DoubleTest
            {
                public double Test { get; set; }
            }

            private class NullableDoubleTest
            {
                public double? Test { get; set; }
            }

            private class BoolTest
            {
                public bool Test { get; set; }
            }

            private class NullableBoolTest
            {
                public bool? Test { get; set; }
            }

            private class ByteTest
            {
                public byte Test { get; set; }
            }

            private class NullableByteTest
            {
                public byte? Test { get; set; }
            }

            private class DateTimeTest
            {
                public DateTime Test { get; set; }
            }

            private class NullableDateTimeTest
            {
                public DateTime? Test { get; set; }
            }

            private class UriTest
            {
                public Uri Test { get; set; }
            }

            private class GuidTest
            {
                public Guid Test { get; set; }
            }

            private class LongTest
            {
                public long Test { get; set; }
            }

            private class NullableLongTest
            {
                public long? Test { get; set; }
            }

            private class ShortTest
            {
                public short Test { get; set; }
            }

            private class CharTest
            {
                public Char Test { get; set; }
            }

            private class NullableCharTest
            {
                public Char? Test { get; set; }
            }

            private class DecimalTest
            {
                public decimal Test { get; set; }
            }

            private class NullableDecimalTest
            {
                public decimal? Test { get; set; }
            }

            private class EnumTest
            {
                public TestEnum Test { get; set; }
            }

            private class ComplexObjectTest
            {
                public StringTest Test { get; set; }
            }

            private class ListTest
            {
                public List<string> Test { get; set; }

                public ListTest()
                {
                    Test = new List<string>();
                }
            }

            private class IEnumerableTest
            {
                public IEnumerable<string> Test { get; set; }

                public IEnumerableTest()
                {
                    Test = new List<string>();
                }
            }

            private class DictionaryTest
            {
                public Dictionary<int, string> Test { get; set; }

                public DictionaryTest()
                {
                    Test = new Dictionary<int, string>();
                }
            }

            private class ArrayTest
            {
                public string[] Test { get; set; }
            }

            [Test]
            public void Should_Not_Populate_When_Max_Depth_Exceeded()
            {
                // Arrange
                autoBuilderConfiguration.MaxDepth = -1;

                // Act
                var objectToPopulate = new StringTest();
                propertyPopulationService.PopulateProperties(objectToPopulate, 0);

                // Assert
                objectToPopulate.Test.ShouldBeNull();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_String()
            {
                // Arrange
                const string resultString = "TestReturn";
                populateStringService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<PropertyInfo>())).Returns(resultString);

                // Act
                var objectToPopulate = new StringTest();
                propertyPopulationService.PopulateProperties(objectToPopulate, 0);

                // Assert
                populateStringService.VerifyAll();
                objectToPopulate.Test.ShouldEqual(resultString);
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Int()
            {
                // Arrange
                populateIntService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<PropertyInfo>())).Returns(It.IsAny<int>());

                // Act
                propertyPopulationService.PopulateProperties(new IntTest(), 0);

                // Assert
                populateIntService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_Int()
            {
                // Arrange
                populateNullableIntService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<int?>(), It.IsAny<PropertyInfo>())).Returns(It.IsAny<int?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableIntTest(), 0);

                // Assert
                populateNullableIntService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Double()
            {
                // Arrange
                populateDoubleService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<PropertyInfo>())).Returns(It.IsAny<double>());

                // Act
                propertyPopulationService.PopulateProperties(new DoubleTest(), 0);

                // Assert
                populateDoubleService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_Double()
            {
                // Arrange
                populateNullableDoubleService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<double?>(), It.IsAny<PropertyInfo>())).Returns(It.IsAny<double?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableDoubleTest(), 0);

                // Assert
                populateNullableDoubleService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Bool()
            {
                // Arrange
                populateBoolService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<bool>(), null)).Returns(It.IsAny<bool>());

                // Act
                propertyPopulationService.PopulateProperties(new BoolTest(), 0);

                // Assert
                populateBoolService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_Bool()
            {
                // Arrange
                populateNullableBoolService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<bool?>(), null)).Returns(It.IsAny<bool?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableBoolTest(), 0);

                // Assert
                populateNullableBoolService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Byte()
            {
                // Arrange
                populateByteService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<byte>(), null)).Returns(It.IsAny<byte>());

                // Act
                propertyPopulationService.PopulateProperties(new ByteTest(), 0);

                // Assert
                populateByteService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_Byte()
            {
                // Arrange
                populateNullableByteService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<byte?>(), null)).Returns(It.IsAny<byte?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableByteTest(), 0);

                // Assert
                populateNullableByteService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_DateTime()
            {
                // Arrange
                populateDateTimeService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<DateTime>(), null)).Returns(It.IsAny<DateTime>());

                // Act
                propertyPopulationService.PopulateProperties(new DateTimeTest(), 0);

                // Assert
                populateDateTimeService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_DateTime()
            {
                // Arrange
                populateNullableDateTimeService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<DateTime?>(), null)).Returns(It.IsAny<DateTime?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableDateTimeTest(), 0);

                // Assert
                populateNullableDateTimeService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Uri()
            {
                // Arrange
                populateUriService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<Uri>(), null)).Returns(It.IsAny<Uri>());

                // Act
                propertyPopulationService.PopulateProperties(new UriTest(), 0);

                // Assert
                populateUriService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Guid()
            {
                // Arrange
                populateGuidService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<Guid>(), null)).Returns(It.IsAny<Guid>());

                // Act
                propertyPopulationService.PopulateProperties(new GuidTest(), 0);

                // Assert
                populateGuidService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Long()
            {
                // Arrange
                populateLongService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<long>(), null)).Returns(It.IsAny<long>());

                // Act
                propertyPopulationService.PopulateProperties(new LongTest(), 0);

                // Assert
                populateLongService.VerifyAll();
            }

            public void Should_Call_Correct_Populate_Service_When_Passed_A_Char()
            {
                // Arrange
                populateCharService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<Char>(), null)).Returns(It.IsAny<Char>());

                // Act
                propertyPopulationService.PopulateProperties(new CharTest(), 0);

                // Assert
                populateCharService.VerifyAll();
            }

            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_Char()
            {
                // Arrange
                populateNullableCharService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<Char?>(), null)).Returns(It.IsAny<Char?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableCharTest(), 0);

                // Assert
                populateNullableCharService.VerifyAll();
            }


            public void Should_Call_Correct_Populate_Service_When_Passed_A_Decimal()
            {
                // Arrange
                populateDecimalService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<decimal>(), null)).Returns(It.IsAny<decimal>());

                // Act
                propertyPopulationService.PopulateProperties(new DecimalTest(), 0);

                // Assert
                populateDecimalService.VerifyAll();
            }

            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_Decimal()
            {
                // Arrange
                populateNullableDecimalService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<decimal?>(), null)).Returns(It.IsAny<decimal?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableDecimalTest(), 0);

                // Assert
                populateNullableDecimalService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Nullable_Long()
            {
                // Arrange
                populateNullableLongService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<long?>(), null)).Returns(It.IsAny<long?>());

                // Act
                propertyPopulationService.PopulateProperties(new NullableLongTest(), 0);

                // Assert
                populateNullableLongService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Short()
            {
                // Arrange
                populateShortService.Setup(x => x.Populate(It.IsAny<string>(), It.IsAny<short>(), null)).Returns(It.IsAny<short>());

                // Act
                propertyPopulationService.PopulateProperties(new ShortTest(), 0);

                // Assert
                populateShortService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_An_Enum()
            {
                // Arrange
                populateEnumService.Setup(x => x.Populate(It.IsAny<string>(), typeof(TestEnum), TestEnum.Item1)).Returns(TestEnum.Item2);

                // Act
                propertyPopulationService.PopulateProperties(new EnumTest(), 0);

                // Assert
                populateEnumService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Complex_Type()
            {
                // Arrange
                populateComplexObjectService.Setup(x => x.Populate(
                    It.IsAny<string>(),
                    typeof(StringTest),
                    null,
                    0,
                    It.IsAny<Func<ConstructorInfo[], int, Func<int, string, Type, object, PropertyInfo, object>, object[]>>(),
                    It.IsAny<Func<int, string, Type, object, PropertyInfo, object>>(),
                    It.IsAny<Func<object, int, object>>())).Returns(null);

                // Act
                propertyPopulationService.PopulateProperties(new ComplexObjectTest(), 0);

                // Assert
                populateComplexObjectService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_List()
            {
                // Arrange
                populateListService.Setup(x => x.Populate(
                    It.IsAny<string>(),
                    typeof(List<string>),
                    It.IsAny<List<string>>(),
                    0,
                    It.IsAny<Func<int, string, Type, object, PropertyInfo, object>>()))
                    .Returns(null);

                // Act
                propertyPopulationService.PopulateProperties(new ListTest(), 0);

                // Assert
                populateListService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_An_IEnumerable()
            {
                // Arrange
                populateListService.Setup(x => x.Populate(
                        It.IsAny<string>(),
                        typeof(IEnumerable<string>),
                        It.IsAny<IEnumerable<string>>(),
                        0,
                        It.IsAny<Func<int, string, Type, object, PropertyInfo, object>>()))
                    .Returns(null);

                // Act
                propertyPopulationService.PopulateProperties(new IEnumerableTest(), 0);

                // Assert
                populateListService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Dictionary()
            {
                // Arrange
                populateDictionaryService.Setup(x => x.Populate(
                    It.IsAny<string>(),
                    typeof(Dictionary<int, string>),
                    It.IsAny<Dictionary<int, string>>(),
                    0,
                    It.IsAny<Func<int, string, Type, object, PropertyInfo, object>>(),
                    It.IsAny<Func<int, string, Type, object, PropertyInfo, object>>()))
                    .Returns(null);

                // Act
                propertyPopulationService.PopulateProperties(new DictionaryTest(), 0);

                // Assert
                populateDictionaryService.VerifyAll();
            }

            [Test]
            public void Should_Call_Correct_Populate_Service_When_Passed_A_Array()
            {
                // Arrange
                populateArrayService.Setup(x => x.Populate(
                    It.IsAny<string>(),
                    typeof(string[]),
                    null,
                    0,
                    It.IsAny<Func<int, string, Type, object, PropertyInfo, object>>()))
                    .Returns(null);

                // Act
                propertyPopulationService.PopulateProperties(new ArrayTest(), 0);

                // Assert
                populateArrayService.VerifyAll();
            }
        }
    }
}
