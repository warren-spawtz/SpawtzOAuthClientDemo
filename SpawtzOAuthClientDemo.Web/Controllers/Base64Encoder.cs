﻿using System;
using System.Text;

namespace SpawtzOAuthClientDemo.Web.Controllers
{
	public static class Base64Encoder
	{
		public static string Base64Encode( string plainText )
		{
			return Convert.ToBase64String( Encoding
				.UTF8.GetBytes( plainText ) );
		}

		public static string Base64Decode( string base64EncodedData )
		{
			return Encoding.UTF8.GetString( Convert
				.FromBase64String( base64EncodedData ) );
		}	
	}
}