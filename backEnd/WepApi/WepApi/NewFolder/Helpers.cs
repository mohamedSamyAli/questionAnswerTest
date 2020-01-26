using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Http;

using Newtonsoft.Json;

namespace WepApi.NewFolder
{
    public static class Helpers
    {
       public static string GetUserName( HttpContext context)
        {
            var user = context.User;
            var firebaseClaim = user.Claims.FirstOrDefault(c => c.Type == "firebase");
            FirebaseUserInfo firebaseUserInfo = null;
            firebaseUserInfo = JsonConvert.DeserializeObject<FirebaseUserInfo>(firebaseClaim.Value);
            return firebaseUserInfo.Identities.Email[0];
        }

    }
}
