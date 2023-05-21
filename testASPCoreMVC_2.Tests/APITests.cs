using testASPCoreMVC_2.Utils;
using Moq;
using NuGet.Protocol.Core.Types;
using Microsoft.AspNetCore.Http.Extensions;

namespace testASPCoreMVC_2.Tests
{
    [TestClass]
    public class APITests
    {
        APIHelper apiHelper = new APIHelper();
        [TestMethod]
        public async Task PositiveUserTestAsync()
        {
            string expectedUser = "{\"data\": {\"user_name\": \"zxvcvzcxvzcx\", \"data\": {\"test\": [{\"90\": [\"1\", \"2\"], \"rating\": 2, \"task\": \"\\u0412\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0443, \\u0441\\u043e\\u0441\\u0442\\u043e\\u044f\\u0449\\u0443\\u044e \\u0442\\u043e\\u043b\\u044c\\u043a\\u043e \\u0438\\u0437 \\u0446\\u0438\\u0444\\u0440, \\u0438 \\u043e\\u043f\\u0440\\u0435\\u0434\\u0435\\u043b\\u0438\\u0442\\u0435 \\u043a\\u043e\\u043b\\u0438\\u0447\\u0435\\u0441\\u0442\\u0432\\u043e \\u0447\\u0435\\u0442\\u043d\\u044b\\u0445 \\u0446\\u0438\\u0444\\u0440 \\u0432 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0435 \\u0431\\u0435\\u0437 \\u0438\\u0441\\u043f\\u043e\\u043b\\u044c\\u0437\\u043e\\u0432\\u0430\\u043d\\u0438\\u044f \\u0441\\u0442\\u0440\\u043e\\u043a\\u043e\\u0432\\u044b\\u0445 \\u0444\\u0443\\u043d\\u043a\\u0446\\u0438\\u0439. \\n\\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440, \\u043f\\u0440\\u043e\\u0433\\u0440\\u0430\\u043c\\u043c\\u0430 \\u043f\\u0440\\u0438\\u043d\\u0438\\u043c\\u0430\\u0435\\u0442 \\u043d\\u0430 \\u0432\\u0445\\u043e\\u0434 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0443 1113351 \\u0438 \\u0432\\u043e\\u0437\\u0432\\u0440\\u0430\\u0449\\u0430\\u0435\\u0442 0.\", \"last_result\": \"\\u0417\\u0430\\u0434\\u0430\\u0447\\u0430 \\u043f\\u0440\\u043e\\u0432\\u0435\\u0440\\u0435\\u043d\\u0430.\\n\\u0420\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442:\\n\\u041d\\u0430\\u0431\\u0440\\u0430\\u043d\\u043e 0 \\u0431\\u0430\\u043b\\u043b\\u043e\\u0432 \\u0438\\u0437 10 \\u0432\\u043e\\u0437\\u043c\\u043e\\u0436\\u043d\\u044b\\u0445.\\n\\u041e\\u0448\\u0438\\u0431\\u043e\\u0447\\u043d\\u044b\\u0435 \\u0440\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442\\u044b \\u043f\\u043e\\u043b\\u0443\\u0447\\u0435\\u043d\\u044b \\u043d\\u0430 \\u0441\\u043b\\u0435\\u0434\\u0443\\u044e\\u0449\\u0438\\u0445 \\u0432\\u0445\\u043e\\u0434\\u043d\\u044b\\u0445 \\u0434\\u0430\\u043d\\u043d\\u044b\\u0445:\\n1) 1223445799\\n\"}, {\"106\": [\"1\", \"2\", \"3\", \"4\"], \"rating\": 3, \"task\": \"\\u041f\\u0440\\u043e\\u0432\\u0435\\u0440\\u044c\\u0442\\u0435, \\u044f\\u0432\\u043b\\u044f\\u0435\\u0442\\u0441\\u044f \\u043b\\u0438 \\u0432\\u0432\\u0435\\u0434\\u0435\\u043d\\u043d\\u0430\\u044f \\u0441\\u0442\\u0440\\u043e\\u043a\\u0430 \\u043a\\u043e\\u0440\\u0440\\u0435\\u043a\\u0442\\u043d\\u044b\\u043c \\u0438\\u043c\\u0435\\u043d\\u0435\\u043c \\u043f\\u0435\\u0440\\u0435\\u043c\\u0435\\u043d\\u043d\\u043e\\u0439 \\u0432 python, \\u0438\\u0441\\u043f\\u043e\\u043b\\u044c\\u0437\\u0443\\u044f \\u0432\\u0441\\u0442\\u0440\\u043e\\u0435\\u043d\\u043d\\u044b\\u0435 \\u0444\\u0443\\u043d\\u043a\\u0446\\u0438\\u0438. \\u041a \\u043f\\u0440\\u0438\\u043c\\u0435\\u0440\\u0443 \\u0432\\u0432\\u0435\\u0434\\u0435\\u043d\\u0430 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0430 numberrr, \\u0432\\u044b\\u0432\\u043e\\u0434 true, \\u0435\\u0441\\u043b\\u0438 \\u0438\\u043c\\u044f \\u043f\\u0435\\u0440\\u0435\\u043c\\u0435\\u043d\\u043d\\u043e\\u0439 \\u043d\\u0435\\u043a\\u043e\\u0440\\u0440\\u0435\\u043a\\u0442\\u043d\\u043e - \\u0432\\u044b\\u0432\\u043e\\u0434 false.\"}, {\"108\": [\"1\", \"2\"], \"rating\": 2, \"task\": \"\\u0412\\u044b\\u0440\\u043e\\u0432\\u043d\\u044f\\u0439\\u0442\\u0435 \\u0432\\u0432\\u0435\\u0434\\u0435\\u043d\\u043d\\u0443\\u044e \\u0441\\u0442\\u0440\\u043e\\u043a\\u0443 \\u043f\\u043e \\u043b\\u0435\\u0432\\u043e\\u043c\\u0443 \\u043a\\u0440\\u0430\\u044e \\u0434\\u043e \\u0432\\u0432\\u0435\\u0434\\u0435\\u043d\\u043d\\u043e\\u0439 \\u043f\\u043e\\u0441\\u043b\\u0435 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0438 \\u0434\\u043b\\u0438\\u043d\\u044b,\\u0437\\u0430\\u043f\\u043e\\u043b\\u043d\\u0438\\u0432 \\u043f\\u0440\\u043e\\u0441\\u0442\\u0440\\u0430\\u043d\\u0441\\u0442\\u0432\\u043e \\u0441\\u0438\\u043c\\u0432\\u043e\\u043b\\u0430\\u043c\\u0438 \\u201c*\\u201d, \\u0432\\u044b\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0443, \\u0438\\u0441\\u043f\\u043e\\u043b\\u044c\\u0437\\u0443\\u0439\\u0442\\u0435 \\u0432\\u0441\\u0442\\u0440\\u043e\\u0435\\u043d\\u043d\\u044b\\u0435 \\u0444\\u0443\\u043d\\u043a\\u0446\\u0438\\u0438. \\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440 \\u0434\\u043b\\u044f \\u0432\\u0445\\u043e\\u0434\\u043d\\u044b\\u0445 \\u0434\\u0430\\u043d\\u043d\\u044b\\u0445:\\n\\u043f\\u0440\\u0438\\u0432\\u0435\\u0442\\n10\\n\\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f \\u0432\\u044b\\u0432\\u043e\\u0434:\\n\\\"\\u043f\\u0440\\u0438\\u0432\\u0435\\u0442****\\\"\"}, {\"110\": [\"1\", \"2\", \"3\", \"4\", \"5\"], \"rating\": 1, \"task\": \"\\u041f\\u0440\\u0435\\u043e\\u0431\\u0440\\u0430\\u0437\\u0443\\u0439\\u0442\\u0435 \\u0432\\u0432\\u0435\\u0434\\u0435\\u043d\\u043d\\u0443\\u044e \\u0441\\u0442\\u0440\\u043e\\u043a\\u0443 \\u0442\\u0430\\u043a, \\u0447\\u0442\\u043e\\u0431\\u044b \\u043a\\u0430\\u0436\\u0434\\u043e\\u0435 \\u0441\\u043b\\u043e\\u0432\\u043e \\u043d\\u0430\\u0447\\u0438\\u043d\\u0430\\u043b\\u043e\\u0441\\u044c \\u0441 \\u0431\\u043e\\u043b\\u044c\\u0448\\u043e\\u0439 \\u0431\\u0443\\u043a\\u0432\\u044b, \\u0438\\u0441\\u043f\\u043e\\u043b\\u044c\\u0437\\u0443\\u044f \\u0432\\u0441\\u0442\\u0440\\u043e\\u0435\\u043d\\u043d\\u0443\\u044e \\u0444\\u0443\\u043d\\u043a\\u0446\\u0438\\u044e, \\u0432\\u044b\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u0440\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442. \\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440, \\u043f\\u0440\\u0438\\u043d\\u0438\\u043c\\u0430\\u0435\\u0442 \\u043d\\u0430 \\u0432\\u0445\\u043e\\u0434\\u0435 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0443 \\u201c\\u043f\\u0440\\u043e\\u0441\\u0442\\u0430\\u044f \\u0441\\u0442\\u0440\\u043e\\u043a\\u0430\\u201d(\\u0431\\u0435\\u0437 \\u043a\\u0430\\u0432\\u044b\\u0447\\u0435\\u043a) \\u0438 \\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442 \\u043d\\u0430 \\u0432\\u044b\\u0445\\u043e\\u0434\\u0435 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0443 \\u201c\\u041f\\u0440\\u043e\\u0441\\u0442\\u0430\\u044f \\u0421\\u0442\\u0440\\u043e\\u043a\\u0430\\u201d(\\u0431\\u0435\\u0437 \\u043a\\u0430\\u0432\\u044b\\u0447\\u0435\\u043a).\"}, {\"115\": [\"1\", \"2\", \"3\"], \"rating\": 2, \"task\": \"\\u0412\\u044b\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u043f\\u043e 3 \\u043f\\u0435\\u0440\\u0432\\u044b\\u0445 \\u0441\\u0438\\u043c\\u0432\\u043e\\u043b\\u0430 \\u043a\\u0430\\u0436\\u0434\\u043e\\u0433\\u043e \\u0441\\u043b\\u043e\\u0432\\u0430 \\u0432 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0435. \\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440, \\u043f\\u0440\\u0438 \\u0432\\u0432\\u043e\\u0434\\u0435 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0438 \\u201c\\u041f\\u0440\\u043e\\u0441\\u0442\\u0430\\u044f \\u0441\\u0442\\u0440\\u043e\\u043a\\u0430\\u201d(\\u0431\\u0435\\u0437 \\u043a\\u0430\\u0432\\u044b\\u0447\\u0435\\u043a) \\u043d\\u0430 \\u0432\\u044b\\u0445\\u043e\\u0434\\u0435 \\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f \\u0441\\u0442\\u0440\\u043e\\u043a\\u0430 \\u201c\\u041f\\u0440\\u043e\\u0441\\u0442\\u0440\\u201d(\\u0431\\u0435\\u0437 \\u043a\\u0430\\u0432\\u044b\\u0447\\u0435\\u043a). \\u0415\\u0441\\u043b\\u0438 \\u0432 \\u0441\\u043b\\u043e\\u0432\\u0435 \\u043c\\u0435\\u043d\\u044c\\u0448\\u0435 3 \\u0441\\u0438\\u043c\\u0432\\u043e\\u043b\\u043e\\u0432, \\u043e\\u043d\\u043e \\u043f\\u0440\\u043e\\u043f\\u0443\\u0441\\u043a\\u0430\\u0435\\u0442\\u0441\\u044f.\", \"last_result\": \"\\u0417\\u0430\\u0434\\u0430\\u0447\\u0430 \\u043f\\u0440\\u043e\\u0432\\u0435\\u0440\\u0435\\u043d\\u0430.\\n\\u0420\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442:\\n\\u041d\\u0430\\u0431\\u0440\\u0430\\u043d\\u043e 0 \\u0431\\u0430\\u043b\\u043b\\u043e\\u0432 \\u0438\\u0437 10 \\u0432\\u043e\\u0437\\u043c\\u043e\\u0436\\u043d\\u044b\\u0445.\\n\\u041e\\u0448\\u0438\\u0431\\u043e\\u0447\\u043d\\u044b\\u0435 \\u0440\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442\\u044b \\u043f\\u043e\\u043b\\u0443\\u0447\\u0435\\u043d\\u044b \\u043d\\u0430 \\u0441\\u043b\\u0435\\u0434\\u0443\\u044e\\u0449\\u0438\\u0445 \\u0432\\u0445\\u043e\\u0434\\u043d\\u044b\\u0445 \\u0434\\u0430\\u043d\\u043d\\u044b\\u0445:\\n1) \\u041a\\u0430\\u043a \\u0436\\u0435 \\u0445\\u043e\\u0440\\u043e\\u0448\\u043e \\u041b\\u0435\\u0442\\u043e\\u043c \\u043d\\u0430 \\u043c\\u043e\\u0440\\u0435\\n\"}, {\"119\": [\"1\", \"2\", \"3\"], \"rating\": 2, \"task\": \"\\u0421\\u043e\\u0441\\u0442\\u0430\\u0432\\u044c\\u0442\\u0435 \\u0441\\u043f\\u0438\\u0441\\u043e\\u043a \\u0438\\u0437 \\u043f\\u0435\\u0440\\u0432\\u044b\\u0445 5 \\u0438 \\u043f\\u043e\\u0441\\u043b\\u0435\\u0434\\u043d\\u0438\\u0445 3 \\u044d\\u043b\\u0435\\u043c\\u0435\\u043d\\u0442\\u043e\\u0432 \\u0437\\u0430\\u0434\\u0430\\u043d\\u043d\\u043e\\u0433\\u043e \\u0441\\u043f\\u0438\\u0441\\u043a\\u0430.\\n\\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440 \\u0434\\u043b\\u044f \\u0441\\u043f\\u0438\\u0441\\u043a\\u0430 [16, 19, 13, 18, 15, 16, 19, 13, 18, 15, 16, 19, 13, 18, 15, 16, 19, 13, 18, 15] \\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f [16, 19, 13, 18, 15, 13, 18, 15]\"}, {\"132\": [\"1\", \"2\", \"3\"], \"rating\": 2, \"task\": \"\\u0412\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u0434\\u0432\\u0430 \\u0441\\u043f\\u0438\\u0441\\u043a\\u0430 \\u0441\\u043b\\u043e\\u0432 \\u0438\\u0437 \\u0434\\u0432\\u0443\\u0445 \\u0441\\u0442\\u0440\\u043e\\u043a \\u0438 \\u0432\\u044b\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u0441\\u043b\\u043e\\u0432\\u0430, \\u0438\\u043c\\u0435\\u044e\\u0449\\u0438\\u0435\\u0441\\u044f \\u0432 \\u043e\\u0431\\u043e\\u0438\\u0445 \\u0441\\u043f\\u0438\\u0441\\u043a\\u0430\\u0445, \\u043d\\u0435 \\u0438\\u0441\\u043f\\u043e\\u043b\\u044c\\u0437\\u0443\\u044f \\u043c\\u043d\\u043e\\u0436\\u0435\\u0441\\u0442\\u0432\\u0430. \\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440 \\u043f\\u0440\\u0438 \\u0432\\u0432\\u043e\\u0434\\u0435:\\n[\\\"he\\\",\\\"she\\\",\\\"it\\\"]\\n[\\\"he\\\",\\\"his\\\",\\\"her\\\",\\\"she\\\"]  \\n\\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f \\u0432\\u044b\\u0432\\u043e\\u0434: [\\\"he\\\",\\\"she\\\"].\"}, {\"133\": [\"1\", \"2\", \"3\"], \"rating\": 2, \"task\": \"\\u0412\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u0434\\u0432\\u0430 \\u0441\\u043f\\u0438\\u0441\\u043a\\u0430 \\u0441\\u043b\\u043e\\u0432 \\u0438\\u0437 \\u0434\\u0432\\u0443\\u0445 \\u0441\\u0442\\u0440\\u043e\\u043a \\u0438 \\u0432\\u044b\\u0432\\u0435\\u0434\\u0438\\u0442\\u0435 \\u0441\\u043b\\u043e\\u0432\\u0430, \\u0438\\u043c\\u0435\\u044e\\u0449\\u0438\\u0435\\u0441\\u044f \\u0432 \\u043e\\u0431\\u043e\\u0438\\u0445 \\u0441\\u043f\\u0438\\u0441\\u043a\\u0430\\u0445, \\u0438\\u0441\\u043f\\u043e\\u043b\\u044c\\u0437\\u0443\\u044f \\u043e\\u043f\\u0435\\u0440\\u0430\\u0446\\u0438\\u0438 \\u0441\\u043e \\u043c\\u043d\\u043e\\u0436\\u0435\\u0441\\u0442\\u0432\\u0430\\u043c\\u0438.\\n\\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440, \\u043f\\u0440\\u0438 \\u0432\\u0445\\u043e\\u0434\\u0435: \\n[\\\"hi\\\", \\\"how\\\", \\\"are\\\", \\\"you\\\"]\\n[\\\"how\\\", \\\"are\\\", \\\"you\\\"]\\n\\u043d\\u0430 \\u0432\\u044b\\u0445\\u043e\\u0434\\u0435 \\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f:\\nhow are you\"}, {\"158\": [\"1\", \"2\", \"3\"], \"rating\": 2, \"task\": \"\\u041d\\u0430\\u043f\\u0438\\u0448\\u0438\\u0442\\u0435 \\u0444\\u0443\\u043d\\u043a\\u0446\\u0438\\u044e fact, \\u043a\\u043e\\u0442\\u043e\\u0440\\u0430\\u044f \\u043f\\u0440\\u0438\\u043d\\u0438\\u043c\\u0430\\u0435\\u0442 \\u0447\\u0438\\u0441\\u043b\\u043e n >= 0 \\u0438 \\u0432\\u043e\\u0437\\u0432\\u0440\\u0430\\u0449\\u0430\\u0435\\u0442 n! - \\u0444\\u0430\\u043a\\u0442\\u043e\\u0440\\u0438\\u0430\\u043b \\u0447\\u0438\\u0441\\u043b\\u0430 n (\\u043f\\u0440\\u043e\\u0438\\u0437\\u0432\\u0435\\u0434\\u0435\\u043d\\u0438\\u0435 \\u0447\\u0438\\u0441\\u0435\\u043b 1, 2, ...n). \\u0424\\u0430\\u043a\\u0442\\u043e\\u0440\\u0438\\u0430\\u043b \\u043d\\u0443\\u043b\\u044f \\u0440\\u0430\\u0432\\u0435\\u043d 1.\\n\\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440, \\u043d\\u0430 \\u0432\\u0445\\u043e\\u0434\\u0435 \\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f:\\n3\\n\\u041d\\u0430 \\u0432\\u044b\\u0445\\u043e\\u0434\\u0435 \\u043e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f:\\n6\", \"last_result\": \"\\u0417\\u0430\\u0434\\u0430\\u0447\\u0430 \\u043f\\u0440\\u043e\\u0432\\u0435\\u0440\\u0435\\u043d\\u0430.\\n\\u0420\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442:\\n\\u041d\\u0430\\u0431\\u0440\\u0430\\u043d\\u043e 10 \\u0431\\u0430\\u043b\\u043b\\u043e\\u0432 \\u0438\\u0437 10 \\u0432\\u043e\\u0437\\u043c\\u043e\\u0436\\u043d\\u044b\\u0445.\\n\"}, {\"159\": [\"1\", \"2\"], \"rating\": 2, \"task\": \"\\u041d\\u0430\\u043f\\u0438\\u0448\\u0438\\u0442\\u0435 \\u0444\\u0443\\u043d\\u043a\\u0446\\u0438\\u044e is_power, \\u043a\\u043e\\u0442\\u043e\\u0440\\u0430\\u044f \\u043f\\u0440\\u0438\\u043d\\u0438\\u043c\\u0430\\u0435\\u0442 \\u0434\\u0432\\u0430 \\u043f\\u043e\\u043b\\u043e\\u0436\\u0438\\u0442\\u0435\\u043b\\u044c\\u043d\\u044b\\u0445 \\u0447\\u0438\\u0441\\u043b\\u0430 a \\u0438 b \\u0432 \\u0441\\u0442\\u0440\\u043e\\u043a\\u0435 \\u0447\\u0435\\u0440\\u0435\\u0437 \\u0437\\u0430\\u043f\\u044f\\u0442\\u0443\\u044e \\u0438 \\u0432\\u043e\\u0437\\u0432\\u0440\\u0430\\u0449\\u0430\\u0435\\u0442 True, \\u0435\\u0441\\u043b\\u0438 a \\u044f\\u0432\\u043b\\u044f\\u0435\\u0442\\u0441\\u044f \\u043f\\u043e\\u043b\\u043d\\u043e\\u0439 \\u0441\\u0442\\u0435\\u043f\\u0435\\u043d\\u044c\\u044e b (\\u043d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440, a == 81, b == 9), \\u0438 False \\u0432 \\u043f\\u0440\\u043e\\u0442\\u0438\\u0432\\u043d\\u043e\\u043c \\u0441\\u043b\\u0443\\u0447\\u0430\\u0435. \\n\\u041d\\u0430\\u043f\\u0440\\u0438\\u043c\\u0435\\u0440 \\u043f\\u0440\\u0438 \\u0432\\u0432\\u043e\\u0434\\u0435:\\n100, 10\\n\\u041e\\u0436\\u0438\\u0434\\u0430\\u0435\\u0442\\u0441\\u044f \\u0432\\u044b\\u0432\\u043e\\u0434:\\nTrue\", \"last_result\": \"\\u0417\\u0430\\u0434\\u0430\\u0447\\u0430 \\u043f\\u0440\\u043e\\u0432\\u0435\\u0440\\u0435\\u043d\\u0430.\\n\\u0420\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442:\\n\\u041d\\u0430\\u0431\\u0440\\u0430\\u043d\\u043e 0 \\u0431\\u0430\\u043b\\u043b\\u043e\\u0432 \\u0438\\u0437 10 \\u0432\\u043e\\u0437\\u043c\\u043e\\u0436\\u043d\\u044b\\u0445.\\n\\u041e\\u0448\\u0438\\u0431\\u043e\\u0447\\u043d\\u044b\\u0435 \\u0440\\u0435\\u0437\\u0443\\u043b\\u044c\\u0442\\u0430\\u0442\\u044b \\u043f\\u043e\\u043b\\u0443\\u0447\\u0435\\u043d\\u044b \\u043d\\u0430 \\u0441\\u043b\\u0435\\u0434\\u0443\\u044e\\u0449\\u0438\\u0445 \\u0432\\u0445\\u043e\\u0434\\u043d\\u044b\\u0445 \\u0434\\u0430\\u043d\\u043d\\u044b\\u0445:\\n1) 100, 10\\n\"}]}}}";
            string actualUser = await apiHelper.getOneUserAsync("zxvcvzcxvzcx");

            Assert.AreEqual(expectedUser, actualUser);
        }
        [TestMethod]
        public async Task NegativeUserTestAsync()
        {
            string expectedUser = "";
            string actualUser = await apiHelper.getOneUserAsync("");
            
            Assert.AreNotEqual(expectedUser, actualUser);
        }
    }
}