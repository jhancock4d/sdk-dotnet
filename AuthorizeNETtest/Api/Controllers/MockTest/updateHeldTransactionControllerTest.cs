using System;
using System.Collections.Generic;

using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers.Test;
using AuthorizeNet.Util;

using NUnit.Framework;

namespace AuthorizeNet.Api.Controllers.MockTest
{
	[TestFixture]
	public class UpdateHeldTransactionTest : ApiCoreTestBase
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

		[Test]
		public void MockupdateHeldTransactionTest()
		{
			//define all mocked objects as final
			var mockController = GetMockController<updateHeldTransactionRequest, updateHeldTransactionResponse>();
			var mockRequest = new updateHeldTransactionRequest
			{
				merchantAuthentication = new merchantAuthenticationType() { name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey },
			};

			var transactionResponse = new transactionResponse()
			{
				accountNumber = "1234",
			};

			var mockResponse = new updateHeldTransactionResponse
			{
				refId = "1234",
				sessionToken = "sessiontoken",
				transactionResponse = transactionResponse
			};

			var errorResponse = new ANetApiResponse();
			var results = new List<String>();
			const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

			SetMockControllerExpectations<updateHeldTransactionRequest, updateHeldTransactionResponse, UpdateHeldTransactionController>(
				mockController.MockObject, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
			mockController.MockObject.Execute(Environment.CUSTOM);
			//mockController.MockObject.Execute();
			// or var controllerResponse = mockController.MockObject.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
			var controllerResponse = mockController.MockObject.GetApiResponse();
			Assert.IsNotNull(controllerResponse);

			Assert.IsNotNull(controllerResponse.transactionResponse);
			LogHelper.Info(Logger, "updateHeldTransaction: Details:{0}", controllerResponse.transactionResponse.accountNumber);
		}
	}
}
