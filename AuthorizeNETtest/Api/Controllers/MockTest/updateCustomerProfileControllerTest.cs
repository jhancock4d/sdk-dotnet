using System;
using System.Collections.Generic;

using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers.Test;

using NUnit.Framework;

namespace AuthorizeNet.Api.Controllers.MockTest
{
	[TestFixture]
	public class UpdateCustomerProfileTest : ApiCoreTestBase
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
		public void MockupdateCustomerProfileTest()
		{
			//define all mocked objects as final
			var mockController = GetMockController<updateCustomerProfileRequest, updateCustomerProfileResponse>();
			var mockRequest = new updateCustomerProfileRequest
			{
				merchantAuthentication = new merchantAuthenticationType { name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey },
			};
			var mockResponse = new updateCustomerProfileResponse
			{
				refId = "1234",
				sessionToken = "sessiontoken",
			};

			var errorResponse = new ANetApiResponse();
			var results = new List<String>();
			const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

			SetMockControllerExpectations<updateCustomerProfileRequest, updateCustomerProfileResponse, UpdateCustomerProfileController>(
				mockController.MockObject, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
			mockController.MockObject.Execute(Environment.CUSTOM);
			//mockController.MockObject.Execute();
			// or var controllerResponse = mockController.MockObject.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
			var controllerResponse = mockController.MockObject.GetApiResponse();
			Assert.IsNotNull(controllerResponse);

		}
	}
}
