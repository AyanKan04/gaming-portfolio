# 🍌 SuperSlime - Banana Cat Edition (Playable Ad)

**Genre:** 3D Arcade / Grow-up (Playable Ad)
**Platform:** Mobile / Web
**Engine:** Unity
**Language:** C#
**Status:** Prototype (Bài tập đánh giá năng lực ứng viên)

**SuperSlime - Banana Cat Edition** là một prototype Playable Ad kết hợp cơ chế gameplay "Grow-up" (giống SuperSlime/Hole.io) gây nghiện với meme Banana Cat nổi tiếng. Trong vòng 30 giây ngắn ngủi, người chơi điều khiển chú mèo chuối đi hút mọi thứ xung quanh để ngày càng to lớn hơn. Game được thiết kế tối ưu cho User Acquisition (UA) với mục tiêu tối đa hóa tỷ lệ chuyển đổi (conversion rate) thông qua trải nghiệm ngắn, vui nhộn, đã tay và mang tính chia sẻ cao (viral).

Game được phát triển dựa trên đề bài của **Nexon Creative Studio VINA** nhằm đánh giá năng lực xây dựng trải nghiệm quảng cáo tương tác (Playable Ads).

---

## 🎮 Gameplay Overview

Game được thiết kế đặc biệt cho Playable Ad với vòng lặp cực ngắn, giới hạn thời gian trong **30 giây**.

**Mục tiêu chính:**
- Di chuyển linh hoạt trong không gian 3D.
- Tự động hút (vacuum) và "ăn" các vật thể xung quanh để thu thập EXP.
- Lên cấp (Level up) để nhân vật tiến hóa: to lớn hơn, tốc độ chạy nhanh hơn và tầm hút rộng hơn.
- Đạt kích thước khổng lồ để "nuốt chửng" cả thành phố trước khi hết giờ.

**Hệ thống phân cấp vật thể (Tier System):**
Người chơi chỉ có thể ăn các vật thể dựa theo cấp độ (Tier) hiện tại của mình. Vật thể được chia thành nhiều mức độ khó/kích thước tăng dần:
- Tier thấp: Đá, cây cỏ, mèo NPC.
- Tier trung: Ô tô, xe cộ.
- Tier cao: Tòa nhà, công ty lớn.

---

## 🕹 Core Gameplay Mechanics

**Player Control & Vacuum System**
- **Movement:** Sử dụng virtual joystick linh hoạt cho phép di chuyển tự do mượt mà (isWalk animation kích hoạt dựa trên cường độ di chuyển).
- **Suction Mechanic:** Tự động kéo các vật thể phù hợp cấp độ (overlap sphere) lại gần người chơi.
- **Shrink Effect:** Khi vật thể bị hút gần vào nhân vật, chúng sẽ nhỏ dần lại một cách mượt mà trước khi biến mất, mang lại cảm giác gameplay rất "đã".

**Progressive Growth (Hệ thống Tiến hóa)**
- Thu thập đủ EXP từ việc ăn vật thể sẽ giúp nhân vật thăng cấp ngay lập tức (CheckLevelUp).
- Mỗi lần thăng cấp sẽ tăng cường toàn diện: Size (Scale lớn lên), Radius (Tầm hút), Pull Speed (Tốc độ hút) và Movement Speed.
- Áp dụng công thức Logarithmic Scaling để tốc độ lớn lên bùng nổ ở giai đoạn đầu (tạo Wow effect) và cân bằng dần ở giai đoạn sau tránh lỗi camera.

---

## 🖥 Game Flow (Luồng Playable Ad chuẩn)

Hệ thống được thiết kế hoàn hảo để dẫn dắt hành vi người dùng trong 30 giây:

1. **Idle (Chờ tương tác):** Nhân vật đứng chờ. Hiển thị Tutorial UI (Bàn tay hướng dẫn lướt theo hình vô cực) để kêu gọi người chơi chạm vào màn hình.
2. **Start:** Ngay khi có tương tác chạm (Pointer Down), hướng dẫn biến mất và đếm ngược 30 giây bắt đầu.
3. **Gameplay Loop:** Người chơi liên tục di chuyển, ăn vật thể từ Tier 0 đến Tier 9, lớn lên và nhận feedback âm thanh/hình ảnh thỏa mãn liên tục.
4. **End:** Khi hết 30 giây, dừng mọi hoạt động di chuyển (`SetCanMove(false)`) và hiển thị màn hình Result kết hợp nút Call-to-Action (Play Now / Install) để điều hướng tải game.

---

## ⚙ Technical Implementation

Dự án áp dụng nhiều kỹ thuật lập trình tối ưu hóa trải nghiệm Game Feel (Juiciness) và hiệu suất:

**Data-Driven Architecture**
- `ItemManager` (Singleton Pattern) tách biệt hoàn toàn dữ liệu (TierData) khỏi in-game entity. Dễ dàng tinh chỉnh balance (cân bằng game) ở một nơi mà không cần đụng vào từng prefab.
- Rất tối ưu bộ nhớ khi map cần spawn hàng ngàn vật thể trong Playable Ad.

**Juiciness (Tăng cường cảm giác Game)**
- **Instant Feedback:** Mỗi lần ăn vật thể sẽ hiển thị ngay lập tức Score Popup kết hợp Sound Effect ăn uống (`PlayEat`), tạo sự thỏa mãn và ghi nhận thành tích tức thì.
- **Scale Punch Coroutine:** Kỹ thuật giật (punch) model nhân vật phóng to nhẹ 1.2x rồi thu lại trong 0.1s mỗi khi level up, giúp nhấn mạnh cảm giác quyền lực.

**UX Optimization (Camera System)**
- **Camera Occlusion (`CameraOcclusion.cs`):** Bắn Raycast xử lý làm mờ (Fade/Transparency) mọi vật cản (nhà cửa, cây cối) nằm giữa nhân vật và camera, đảm bảo người chơi không bao giờ bị mất dấu nhân vật.
- **Dynamic Camera Follow (`CameraFollow.cs`):** Camera tự động tính toán bù trừ (offset) độ cao (Y) và lùi xa (Z) tương ứng dựa trên Scale của nhân vật đang lớn lên từng giây.

---

## 🎨 Art & Visual Design

- **Phong cách:** Humor (hài hước), Cuteness (dễ thương), và Meme-worthy.
- Thiết kế kết hợp một cách lố bịch và gây cười khi một bé Mèo Chuối đang khóc (Banana Cat Cry) lại có khả năng nuốt chửng cả thế giới (từ viên đá đến tòa cao ốc). 
- Sự kết hợp giữa meme nổi tiếng và cơ chế chơi gây nghiện giúp sản phẩm có tính Viral và Shareable cực cao trên mạng xã hội.

---

## 📂 Project Structure

Cấu trúc thư mục được quy hoạch chuẩn mực trong Unity theo tài liệu:

```text
Assets
├── Animations/
├── Audio/
├── Materials/
├── Prefabs/
├── Scenes/
├── Script/
├── TextMesh Pro/
└── Texture/
```

**Các script chính đóng vai trò Core Logic:**
- `ItemManager.cs` / `Item.cs`
- `PlayerController.cs`
- `CameraOcclusion.cs` / `CameraFollow.cs`

---

## ▶ Demo & Tài nguyên

- **Thư mục Project (GDD, Video Demo, Unity Package):** [Google Drive Link](https://drive.google.com/drive/folders/1HjRDZOI5EB1W7MZ07WncXNOTMR3oRXw2)
- **Repo GitHub:** [Banana-Cat](https://github.com/AyanKan04/Banana-Cat)
