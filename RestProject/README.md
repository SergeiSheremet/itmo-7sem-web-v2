# RestProject

* Общий вид страницы API, настроенной через Swagger
![](https://sun9-5.userapi.com/impg/_UCrfrnX0euVITCPNOIr43R3sLsxocf2JMLwqA/aImnE154BMo.jpg?size=945x490&quality=96&proxy=1&sign=ada3ae45a0db54a8ce01927006d372ca&type=album)
* Последовательность запросов для демонстрации
    1. Get-запрос в неинициализированное хранилище
    ![](https://sun9-15.userapi.com/impg/1P5Nb67mWZNZ6SFt19fyKd5bR7usjFy88hnj1Q/XZ1FQA96iC4.jpg?size=899x384&quality=96&proxy=1&sign=c4969976c7b45cc822b12a277bd6d388&type=album)
    Результат: HTTP 204 No Content
    ![](https://sun9-63.userapi.com/impg/CvKXqck2WBI7o3dXEtjvyZbflq8wucsUGFXHFg/ktR_oBXL1VY.jpg?size=900x570&quality=96&proxy=1&sign=ce003c376c31e54a4dd427f08acf53c8&type=album)
    1. Put-запрос в неинициализированное хранилище
    ![](https://sun9-45.userapi.com/impg/w3HUVrMHeR17DRcW8TbIFG2gYn3wbesvu0bxcQ/ECR30q8WjFA.jpg?size=901x774&quality=96&proxy=1&sign=a224c8ed93b6593390802751551c1504&type=album)
    Результат: HTTP 400 Bad Request
    ![](https://sun9-43.userapi.com/impg/4sqSpxBR5iq4_Of7z_iNWiJeSiCBvVFrPb-38w/Esh9qc6veMU.jpg?size=901x763&quality=96&proxy=1&sign=df474e846c5be216bd74f1fc73e34300&type=album)
    1. Patch-запрос в неинициализированное хранилище
    ![](https://sun9-65.userapi.com/impg/gbvClgNFKXYOeTMJNl_auP0ZsHMWJouWfbkz-w/VKcoOgY3aGs.jpg?size=901x778&quality=96&proxy=1&sign=8dc714ac713ec76e85c4d9a9ae125ebe&type=album)
    Результат: HTTP 400 Bad Request
    ![](https://sun9-34.userapi.com/impg/QYFLeKHrcIAuHYwSASZf8OLg-xSEyk-YSBtA_w/M-u17Mb5z0M.jpg?size=901x762&quality=96&proxy=1&sign=50798b7bc3bc50960e2d6560e4ce77a4&type=album)
    1. Post-запрос в неинициализированное хранилище
    ![](https://sun9-26.userapi.com/impg/E9HZ-KwVreENvOz1jS7MQ9qG6knTjiXW3ipofg/YNgIitzXVaw.jpg?size=900x779&quality=96&proxy=1&sign=51110f773177b1c424ada49407082491&type=album)
    Результат: HTTP 200 Ok
    ![](https://sun9-40.userapi.com/impg/n-vHmqmlIC7ne7kzpeQmueIMsKBcnKQMYPjtjA/OgHAfsKtlSA.jpg?size=901x749&quality=96&proxy=1&sign=aa3a6ac84048b984c3cf4b9e79f27c54&type=album)
    1. Get-запрос для проверки работы Post
    Результат: HTTP 200 Ok
    ![](https://sun9-7.userapi.com/impg/m0-St9hgYiD2JXniM6dF6ClQkZees819cnG82w/6v3zQBMbse8.jpg?size=900x700&quality=96&proxy=1&sign=bb4569df861c353986299b96e8fb75d2&type=album)
    1. Post-запрос в инициализированное хранилище
    ![](https://sun9-11.userapi.com/impg/fEpD_PUe_CKPpinbQt2sfvMSqXfQcuRExe3FOw/8bV7VHh0tz0.jpg?size=900x779&quality=96&proxy=1&sign=67a3c3fe3d3a2ffc267613fad89b4ade&type=album)
    Результат: HTTP 400 Bad Request
    ![](https://sun9-50.userapi.com/impg/_Su1Um7UjfUc-6yofto7YU7t6n3fa96SWQs11w/wl3cqJbaymw.jpg?size=900x762&quality=96&proxy=1&sign=9a604a2f49af62aa02e9e35954fc5012&type=album)
    1. Put-запрос в инициализированное хранилище
    ![](https://sun9-31.userapi.com/impg/EvZrVOXvTRzUDACHS9mQwXzhNfc2lwoOpvvv_w/jh27UcxCHc4.jpg?size=901x779&quality=96&proxy=1&sign=d9b281c2b53ad67d9a984f0d4284c4f0&type=album)
    Результат: HTTP 200 Ok
    ![](https://sun9-67.userapi.com/impg/U7aLIlt4xdVqwDKjvuSfwK1rM31j3x99uBEmHw/kmkBe712944.jpg?size=901x749&quality=96&proxy=1&sign=3d369b3cda96d583e2012e6f42776b15&type=album)
    1. Get-запрос для проверки работы Put
    Результат: HTTP 200 Ok
    ![](https://sun9-16.userapi.com/impg/accPvTVKGWiDyPtKYnLhXd5-VvNKj9HAtYp9Tg/OAdFZeZXuCI.jpg?size=901x698&quality=96&proxy=1&sign=34539cec6d7519fab0991d236c8730b4&type=album)
    1. Patch-запрос в инициализированное хранилище
    ![](https://sun9-16.userapi.com/impg/bwZd1aeD_635cDXxOP9UQ6FyZn3bhgHd9cv6Ig/aCrtemwTfdA.jpg?size=900x778&quality=96&proxy=1&sign=ab7964dfabc704402a0b206221456523&type=album)
    Результат: HTTP 200 Ok
    ![](https://sun9-19.userapi.com/impg/p8wroICu1HjtiTfpA9Df5PECz0uhhdywfTfC0Q/nj90RXig_Ps.jpg?size=901x747&quality=96&proxy=1&sign=11fa9c496cd0dad45327cc7f5b322af6&type=album)
    1. Get-запрос для проверки работы Patch
    Результат: HTTP 200 Ok
    ![](https://sun9-76.userapi.com/impg/frCPs7KbhioFJGGUOKqSIYsHPQ434WhXFwqiAA/MeX-qfKSQq8.jpg?size=900x767&quality=96&proxy=1&sign=6f1b94551cad39090d4137000c6ab23a&type=album)
    
    
    