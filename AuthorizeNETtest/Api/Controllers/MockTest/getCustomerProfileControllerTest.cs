using System;
using System.Collections.Generic;

using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Test;
using AuthorizeNet.Util;

using NUnit.Framework;

namespace AuthorizeNet.Api.Controllers.MockTest
{
	[TestFixture]
	public class GetCustomerProfileTest : ApiCoreTestBase
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
		public void MockgetCustomerProfileTest()
		{
			//define all mocked objects as final
			var mockController = GetMockController<getCustomerProfileRequest, getCustomerProfileResponse>();
			var mockRequest = new getCustomerProfileRequest
			{
				merchantAuthentication = new merchantAuthenticationType { name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey },
			};
			var customerProfileMaskedType = new customerProfileMaskedType
			{
				customerProfileId = "1234",
			};
			var mockResponse = new getCustomerProfileResponse
			{
				refId = "1234",
				sessionToken = "sessiontoken",
				profile = customerProfileMaskedType,
			};

			var errorResponse = new ANetApiResponse();
			var results = new List<String>();
			const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

			SetMockControllerExpectations<getCustomerProfileRequest, getCustomerProfileResponse, GetCustomerProfileController>(
				mockController.MockObject, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
			mockController.MockObject.Execute(Environment.CUSTOM);
			//mockController.MockObject.Execute();
			// or var controllerResponse = mockController.MockObject.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
			var controllerResponse = mockController.MockObject.GetApiResponse();
			Assert.IsNotNull(controllerResponse);

			Assert.IsNotNull(controllerResponse.profile);
			LogHelper.Info(Logger, "getCustomerProfile: Details:{0}", controllerResponse.profile);
		}
	}
}
