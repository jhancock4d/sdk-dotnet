using System;

using AuthorizeNet.Api.Contracts.V1;

using NUnit.Framework;

namespace AuthorizeNet.Api.Controllers.Test
{
	[TestFixture]
	public class AllGeneratedEnumTest : ApiCoreTestBase
	{

		[SetUp]
		public new static void SetUpBeforeClass()
		{
			ApiCoreTestBase.SetUpBeforeClass();
		}

		[TearDown]
		public new static void TearDownAfterClass()
		{
			ApiCoreTestBase.TearDownAfterClass();
		}

		[SetUp]
		public new void SetUp()
		{
			base.SetUp();
		}

		[TearDown]
		public new void TearDown()
		{
			base.TearDown();
		}

		//Generated by cs-enum-test on Tue 11/04/2014-11:49:24.42
		[Test]
		public void AllEnumTest()
		{

			foreach (var anEnum in Enum.GetValues(typeof(messageTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out messageTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(bankAccountTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out bankAccountTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(echeckTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out echeckTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(ARBSubscriptionStatusEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out ARBSubscriptionStatusEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(paymentMethodEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out paymentMethodEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(ARBGetSubscriptionListOrderFieldEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out ARBGetSubscriptionListOrderFieldEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(TransactionListOrderFieldEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out TransactionListOrderFieldEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(deviceActivationEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out deviceActivationEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(afdsTransactionEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out afdsTransactionEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(messageTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out messageTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(customerTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out customerTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(merchantInitTransReasonEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out merchantInitTransReasonEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(authIndicatorEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out authIndicatorEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(EncodingType)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out EncodingType enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(EncryptionAlgorithmType)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out EncryptionAlgorithmType enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(OperationType)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out OperationType enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(ItemChoiceType1)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out ItemChoiceType1 enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(customerProfileTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out customerProfileTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(ARBSubscriptionUnitEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out ARBSubscriptionUnitEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(webCheckOutTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out webCheckOutTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}
			foreach (var anEnum in Enum.GetValues(typeof(ItemChoiceType)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out ItemChoiceType enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(validationModeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out validationModeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(splitTenderStatusEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out splitTenderStatusEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(TransactionGroupStatusEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out TransactionGroupStatusEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(ARBGetSubscriptionListSearchTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out ARBGetSubscriptionListSearchTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(accountTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out accountTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(cardTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out cardTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(FDSFilterActionEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out FDSFilterActionEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(permissionsEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out permissionsEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(settingNameEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out settingNameEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(settlementStateEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out settlementStateEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(transactionStatusEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out transactionStatusEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(transactionTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out transactionTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(CustomerPaymentProfileSearchTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out CustomerPaymentProfileSearchTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(CustomerPaymentProfileOrderFieldEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out CustomerPaymentProfileOrderFieldEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(AUJobTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out AUJobTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}

			foreach (var anEnum in Enum.GetValues(typeof(paymentMethodsTypeEnum)))
			{
				var aValue = anEnum.ToString();
				Assert.IsTrue(Enum.TryParse(aValue, out paymentMethodsTypeEnum enumFromValue));
				Assert.AreEqual(anEnum, enumFromValue);
			}
		}

		/*
        private <T extends enum > void XX<T>()
        {
            for ( T anEnum : T.values())
            {
                String unitValue = anEnum.value();
                T unitEnum = T.fromValue(unitValue);
                Assert.assertEquals(anEnum, unitEnum);
            }
        }
        */
	}
}
