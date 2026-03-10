# 1주차 과제: 나만의 디지털 명함 제작
- 이름: 김건우 (25010012)

- 핵심기능: 배경색 랜덤 변경, 깃허브 주소 연동,사진 변경, 마우스 접근시 사진의 경계선 스타일 변함

## 실행 화면
기본 실행화면

<img width="406" height="274" alt="스크린샷 2026-03-08 오후 7 54 03" src="https://github.com/user-attachments/assets/eb69b00c-543a-42df-b875-eb1f02880de0" />


## 구현 시 어려웠던 점
- SNS 연결을 구현하기 위해  System.Diogonstics.ProcessStart("URL주소");라는 코드를 이용해서 작성했지만,
  .NET5 이상 버전에서는 보안상의 이유로 UseShellExcute속성의 기본값이 false로 변경되어 브라우저를 직접 호출하지 못한다는 것을 알게 됨.
  따라서
  System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
  {
  FileName = "URL",
  UseShellExecute = true
  ]);
  로 코드를 수정해서 구현 함.
