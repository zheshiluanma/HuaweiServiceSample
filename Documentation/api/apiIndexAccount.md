# HuaweiService.Account



#### Scenario: Create authorization option``创建帐号登录选项``
|<div style="width: 350pt">Description</div>| Api | Reference |
---|---|---
A default constructor.<br>``默认的构造方法``|AccountAuthParamsHelper()|https://developer.huawei.com/consumer/cn/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
Constructs AccountAuthParamsHelper using the existing AccountAuthParams object..<br>``使用已有的AccountAuthParams对象来创建AccountAuthParamsHelper``|AccountAuthParamsHelper(AccountAuthParams params)|https://developer.huawei.com/consumer/cn/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
Requests a user to authorize an app to obtain the user ID.<br>`` 请求帐号用户授权应用获取User ID。 ``|setUid()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Requests a user to authorize an app to obtain the authorization code.<br>`` 请求帐号用户授权应用获取Authorization Code。 ``|setAuthorizationCode()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Adds a specified Scope to authorization parameters to request a user to authorize an app to obtain the user information specified by the scope.<br>`` 授权配置中增加指定的Scope，请求帐号授予Scope指定的权限。 ``|setScopeList(List<Scope> scopeList)|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Requests a user to authorize an app to obtain the email address.<br>`` 请求帐号用户授权应用获取Email地址。 ``|setEmail()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Requests a user to authorize an app to obtain the UnionID and OpenID.<br>`` 请求帐号用户授权应用获取unionId和openId。 ``|setId()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Requests a user to authorize an app to obtain the ID token.<br>`` 配置授权ID Token，请求帐号用户授权应用获取ID Token。 ``|setIdToken()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Requests a user to authorize an app to obtain the account information, such as the nickname and profile picture.<br>`` 请求帐号用户授权应用获取帐号信息，如昵称和头像等。 ``|setProfile()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Requests a user to authorize an app to obtain the carrier ID.<br>`` 请求帐号用户授权应用获取运营商ID。 ``|setCarrierId()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
 Specifies the signature algorithm type for the ID token. The default algorithm is RS256. If your app supports the PS256 algorithm, you can use the idTokenSignAlg parameter to specify this algorithm. For details, please refer to Cryptographic Algorithms for Digital Signatures and MACs.<br>`` 指定ID Token的签名算法类型。如果您的应用支持使用PS256算法，则可以通过此参数指定，否则默认使用RS256算法。详情请参见算法类型定义。 ``|setIdTokenSignAlg(int idTokenSignAlg)|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849
  Requests a user to authorize an app to obtain the AccessToken .<br>`` 请求帐号用户授权应用获取AccessToken。 ``|setAccessToken()|https://developer.huawei.com/consumer/cn/doc/development/HMSCore-Guides/dev-guide-account-0000001050048888
 Constructs AccountAuthParams using the existing AccountAuthParamsHelper object.<br>`` 使用当前的AccountAuthParamsHelper创建AccountAuthParams对象。 ``|createParams()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthparamshelper-0000001050438849


 #### Scenario: Signs in to an app with an ID.``帐号登录客户端``
|<div style="width: 350pt">Description</div>| Api | Reference |
---|---|---
Obtains the Intent object of the ID authorization screen. The screen can be displayed through startActivityForResult. .<br>`` 获取登录授权页面的Intent，可以通过startActivityForResult拉起授权页面。 ``|getSignInIntent()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthservice-0000001050199395
 Implements silent sign-in. This silentSignIn() does not display the authorization screen. .<br>`` 静默授权，该接口不会拉起授权页面。 ``|silentSignIn()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthservice-0000001050199395
 Signs out. .<br>`` 退出。 ``|signOut()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthservice-0000001050199395
 Cancels the authorization. .<br>`` 取消授权。 ``|cancelAuthorization()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthservice-0000001050199395
 Obtains icon information. .<br>`` 获取图标信息。``|getChannel()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthservice-0000001050199395
 Obtains the Intent object of the dialog box that requests independent authorization from users. The dialog box can be displayed through startActivityForResult.<br>`` 获取独立授权弹框的Intent，可通过startActivityForResult拉起独立授权弹框。 ``|getIndependentSignInIntent(String accessToken)|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/accountauthservice-0000001050199395

 #### Scenario: Signed-in ID information, including the ID, nickname, profile picture URI, permission, and access token.``登录的帐号信息，包含ID、显示名称、头像URI、权限、AccessToken等信息。``
|<div style="width: 350pt">Description</div>| Api | Reference |
---|---|---
  Constructs an AuthAccount object whose attributes are left empty. .<br>`` 构造一个AuthAccount空对象，其属性值都为空。 ``|createDefault()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the access token from ID information. .<br>`` 返回用户的AccessToken。 ``|getAccessToken()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the account from ID information. .<br>`` 从帐号信息中获取Account。 ``|getAccount(Context context)|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the nickname from ID information. .<br>`` 从帐号信息中获取昵称。 ``|getDisplayName()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the email address from ID information. .<br>`` 从帐号信息中获取Email。 ``|getEmail()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the family name from ID information. .<br>`` 从帐号信息中获取FamilyName。 ``|getFamilyName()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the given name from ID information. .<br>`` 从帐号信息中获取GivenName。 ``|getGivenName()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the authorized scopes from ID information. .<br>`` 从帐号信息中获取已经授权的Scope。 ``|getAuthorizedScopes()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the ID token from ID information. .<br>`` 从帐号信息中获取ID Token。 ``|getIdToken()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the profile picture URI from ID information. .<br>`` 从帐号信息中获取头像URI。 ``|getAvatarUri()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the authorization code from ID information. .<br>`` 从帐号信息中获取授权码code。 ``|getAuthorizationCode()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the code of the service country or region from ID information. .<br>`` 获取当前帐号所属的服务地国家。 ``|getServiceCountryCode()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the UnionID from ID information. .<br>`` 从帐号信息中获取unionId。 ``|getUnionId()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the OpenID from ID information. .<br>`` 从帐号信息中获取openId。 ``|getOpenId()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the type of an ID. .<br>`` 获取帐号类型。 ``|getAccountFlag()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810
 Obtains the carrier ID. .<br>`` 获取运营商ID。 ``|getCarrierId()|https://developer.huawei.com/consumer/en/doc/development/HMSCore-References/authaccount-0000001050315810

  #### Scenario: Service of reading SMS messages.``短信服务``
|<div style="width: 350pt">Description</div>| Api | Reference |
---|---|---
Enables the service of reading SMS messages until the SMS messages that meet the rules are obtained or the service times out (the timeout duration is 5 minutes).<br>`` 开启读取短信的服务，直到读取到符合规则的短信或者服务超时（超时时间5分钟）。 ``|start(Activity activity)|https://developer.huawei.com/consumer/cn/doc/development/HMSCore-References/account-support-sms-readsmsmanager-0000001050050553
Enables the service of reading SMS messages until the SMS messages that meet the rules are obtained or the service times out (the timeout duration is 5 minutes).<br>`` 开启读取短信的服务，直到读取到符合规则的短信或者服务超时（超时时间5分钟）。 ``|startConsent(Activity activity, String phoneNumber)|https://developer.huawei.com/consumer/cn/doc/development/HMSCore-References/account-support-sms-readsmsmanager-0000001050050553