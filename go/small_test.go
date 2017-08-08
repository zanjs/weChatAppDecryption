// small_test.go
package small

import (
	// "encoding/base64"
	"fmt"
	"testing"
)

var (
	encryptedData = "CiyLU1Aw2KjvrjMdj8YKliAjtP4gsMZMQmRzooG2xrDcvSnxIMXFufNstNGTyaGS9uT5geRa0W4oTOb1WT7fJlAC+oNPdbB+3hVbJSRgv+4lGOETKUQz6OYStslQ142dNCuabNPGBzlooOmB231qMM85d2/fV6ChevvXvQP8Hkue1poOFtnEtpyxVLW1zAo6/1Xx1COxFvrc2d7UL/lmHInNlxuacJXwu0fjpXfz/YqYzBIBzD6WUfTIF9GRHpOn/Hz7saL8xz+W//FRAUid1OksQaQx4CMs8LOddcQhULW4ucetDf96JcR3g0gfRK4PC7E/r7Z6xNrXd2UIeorGj5Ef7b1pJAYB6Y5anaHqZ9J6nKEBvB4DnNLIVWSgARns/8wR2SiRS7MNACwTyrGvt9ts8p12PKFdlqYTopNHR1Vf7XjfhQlVsAJdNiKdYmYVoKlaRv85IfVunYzO0IKXsyl7JCUjCpoG20f0a04COwfneQAGGwd5oa+T8yO5hzuyDb/XcxxmK01EpqOyuxINew=="
	iv            = "r7BXXKkLb8qrSNn05n0qiA=="
	sessionKey    = "tiihtNczf5v6AKRyjwEUhQ=="
)

func TestGetWxSessionKey(t *testing.T) {
	// ws, err := GetWxSessionKey(appid, secret, code)
	// if err != nil {
	// 	t.Fatal(err)
	// }
	// fmt.Println(ws)
	// if ws.ErrCode != 0 {
	// 	t.Log(ws.ErrMsg)
	// 	t.FailNow()
	// }
	// fmt.Println(ws.Openid)
	// fmt.Println(ws.SessionKey)
	// if CheckSignature(signature, sessionKey, rawData) != true {
	// 	t.Fatal("CheckSignature failed")
	// 	t.FailNow()
	// }
	u, err := GetWxUserInfo(sessionKey, encryptedData, iv)
	if err != nil {
		t.Fatal(err)
		t.FailNow()
	}
	fmt.Println(u)

}
