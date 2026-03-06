# 🎮 Game Portfolio | Danh Sách Game Portfolio

> [English](#english-version) | [Tiếng Việt](#phiên-bản-tiếng-việt)

---

## English Version

# 🎮 Game Portfolio

A collection of indie game projects showcasing diverse gameplay mechanics, original artwork, and game design principles. Each game demonstrates different technical challenges and creative solutions in game development.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Games](#games)
  - [Space Shoot](#space-shoot)
  - [Running](#running)
  - [OKLA](#okla)
- [Technical Highlights](#technical-highlights)
- [Art & Design](#art--design)
- [Getting Started](#getting-started)
- [Contact](#contact)

---

## 🎯 Overview

This portfolio represents a progression in game development, from foundational mechanics (OKLA) to more complex systems (Running) and refined action gameplay (Space Shoot). Each project emphasizes:

- **Original artwork and animations** — hand-drawn by the developer
- **Polished game feel** — responsive controls, visual feedback, and audio integration
- **User experience** — intuitive menus, settings, and game flow
- **Code quality** — clean architecture supporting gameplay loops and content expansion

---

## 🕹️ Games

### 🚀 Space Shoot

**Status:** Demo | **Platforms:** PC

A fast-paced space shooter where players pilot a fighter jet against waves of alien warships. The game combines action-oriented mechanics with progression through structured levels and a challenging boss encounter.

#### Gameplay Features:
- **Core Mechanics:** Shoot-'em-up action with directional movement and continuous fire
- **Enemy Variety:** Multiple warship types with distinct behaviors and loot drops
- **Progression System:** 3 levels (2 standard + 1 boss level) with increasing difficulty
- **Item System:** Collect power-ups and consumables during combat for tactical advantage
- **Score System:** Earn points by eliminating enemies, compete for high scores

#### Game Features:
- **Pause/Resume:** Full gameplay suspension with UI overlay
- **Menu System:** Navigate between play modes, settings, and quit options
- **Audio Settings:** Independent volume control for music and sound effects (SFX)
- **Game Loop:** Continuous play with restart functionality

#### Technical Highlights:
- Event-driven architecture for enemy waves and spawning
- Collision detection for bullets, items, and hazards
- UI framework supporting multiple menus and states
- Audio management system for dynamic sound design

#### Art & Visuals:
- **100% Hand-Drawn:** All artwork, sprites, and animations created by the developer
- Pixel-art or stylized vector aesthetic (depending on implementation)
- Animated character sprites with multiple directional frames
- Visual effects for impacts, explosions, and power-up pickups

**Repository:** [Space Shoot](./project-1-spaceshoot/)

---

### 🏃 Running

**Status:** Demo | **Platforms:** Mobile & PC (3D)

An endless runner game featuring a rolling wheel character navigating procedurally challenging environments. The game balances simple core mechanics with depth through progression systems and physics-based challenge design.

#### Gameplay Modes:

**Story Mode (Level-Based):**
- 5 curated levels with progressive difficulty scaling
- Hand-crafted obstacle layouts and pacing
- Checkpoint system for progression

**Endless Mode (Arcade):**
- Infinite procedural terrain generation
- Continuous speed acceleration based on game time and physics momentum
- Permadeath mechanics with revival system

#### Core Mechanics:
- **Physics-Based Movement:** Wheel rolls naturally with inertia-driven speed escalation
- **Obstacle Variety:** Multiple hazard types requiring different evasion strategies
- **Collectibles:** Gold coins scattered throughout levels for currency and scoring
- **Power-ups:** Temporary boosts (speed boost, shield protection) affecting gameplay

#### Progression Systems:
- **Currency System:** Collect coins to unlock revivals in endless mode
- **Revival Mechanic:** Spend coins to continue after collision instead of game over
- **Difficulty Scaling:** Obstacles increase in frequency and complexity over time

#### Game Features:
- **Menu System:** Navigate between story mode, endless mode, and settings
- **Pause/Resume:** Suspend gameplay at any time
- **Audio Settings:** Volume control for background music and sound effects
- **Game Loop:** Seamless transitions between levels and mode restarts

#### Technical Highlights:
- 3D physics engine integration (wheel dynamics and collision)
- Procedural level generation for endless mode variety
- Performance optimization for continuous gameplay
- State management across different game modes

#### Art & Visuals:
- **Custom 3D Environment:** Hand-designed maps and building assets for story levels
- **Asset Integration:** Professional 3D models for base obstacles and terrain
- **Visual Polish:** Particle effects for coin collection, impacts, and collisions
- **HUD Design:** Clean interface displaying score, timer, and currency

**Repository:** [Running](./project-2-running/)

---

### 🪙 OKLA

**Status:** First Demo Project | **Platforms:** PC

A foundational casual game designed as an entry point into game development. Players control a character to collect falling items within a time limit, balancing risk versus reward with mixed positive and negative collectibles.

#### Gameplay:
- **Objective:** Maximize score by collecting beneficial items before the timer expires
- **Character Control:** Simple 2D movement (left/right or 360-degree direction)
- **Item Variety:** Mixed item types with different effects:
  - **Positive:** Coins, health pickups, speed boosts
  - **Negative:** Obstacles, hazards, penalty items
- **Time Pressure:** Countdown timer creates urgency and challenge

#### Game Design:
- **Learning Tool:** First complete game project demonstrating core gameplay loop
- **Simple Mechanics:** Easy to learn, supports diverse gameplay styles
- **Engaging Feedback:** Visual and audio cues for item collection
- **High Score System:** Track best performance across sessions

#### Technical Foundation:
- Basic state management (menu, gameplay, game over)
- Collision detection for item pickups
- Spawning and object pooling systems
- Simple UI for menus and HUD display

#### Art & Visuals:
- **Hand-Drawn Character:** Custom sprite design with idle and movement animation
- **Item Sprites:** Distinct visual designs for collectibles and hazards
- **Particle Effects:** Visual feedback for collection and collisions
- **Clean UI:** Simple, readable menus and game overlays

**Repository:** [OKLA](./project-3-okla/)

---

## 🎨 Technical Highlights

### Shared Development Practices

#### Graphics & Animation:
- **100% Hand-Drawn Artwork:** All character sprites and visual assets created from scratch
- **Custom Animations:** Frame-by-frame animations for characters, enemies, and effects
- **Art Direction:** Cohesive visual style maintained across all games

#### Audio System:
- **Music Integration:** Background loops supporting game state changes
- **Sound Effects:** Contextual audio for interactions (collection, collision, UI)
- **Volume Management:** User-accessible audio settings with independent music/SFX sliders

#### Game Architecture:
- **State Management:** Clean separation between menu, gameplay, and pause states
- **Input Handling:** Responsive control schemes (keyboard/gamepad compatible)
- **Event System:** Decoupled communication between game systems
- **Scene Management:** Efficient loading and unloading of game content

#### User Experience:
- **Intuitive UI:** Clear navigation through menus and settings
- **Pause Functionality:** Full gameplay suspension with resumable state
- **Settings Persistence:** User preferences saved between sessions
- **Feedback Systems:** Visual and audio cues for all player interactions

### Asset Creation & 3D (Running-Specific):
- **3D Foundation:** Leverages standard 3D engine assets (terrain, obstacles, physics)
- **Custom Level Design:** Hand-crafted environment layouts for story mode
- **Procedural Supplementary Systems:** Dynamic generation supports endless mode variety
- **Optimization Techniques:** Efficient rendering and memory management for continuous play

---

## 🎯 Art & Design

### Creative Process

Every visual element across these games—from character sprites to environment details—represents custom artwork created during development:

**Character Design:**
- Original character concepts with distinct visual identity
- Multiple animation frames for movement and actions
- Expressive visual communication of gameplay state

**Environment & UI:**
- Custom background art and environmental details
- Branded interface design consistent with game aesthetic
- Visual effects (particles, transitions) reinforcing game feel

**Running Game (3D-Specific):**
- Procedurally generated supporting elements built on standard 3D assets
- Custom architectural designs for story mode environments
- Cohesive visual language across 3D and UI layers

### Design Philosophy

- **Visual Clarity:** Readable sprites and UI supporting gameplay at a glance
- **Feedback Integration:** Visual cues reinforce player actions and consequences
- **Performance Balance:** Artistic ambition tempered by runtime optimization
- **Accessibility:** Colorblind-friendly palettes and high-contrast designs (where applicable)

---

## 🚀 Getting Started

### Prerequisites:
- **Space Shoot & OKLA:** Game engine with 2D rendering support (e.g., Unity, Godot)
- **Running:** 3D game engine (e.g., Unity 3D, Unreal Engine)
- Basic knowledge of your chosen platform

### Installation:

Each game folder contains:
- Complete source code
- Assets (sprites, audio, data files)
- Build configuration for your platform
- README with setup instructions

**To play a game:**
1. Navigate to the project folder
2. Follow the individual game's `README.md` for platform-specific build steps
3. Launch the game and enjoy!

### Development:

Each project is structured for easy content expansion:
- **Level Design:** Add new levels by creating level data files
- **Balance Adjustments:** Tweak game parameters in configuration files
- **Asset Replacement:** Seamlessly substitute art and audio assets
- **Feature Extension:** Well-organized code supports new mechanics

---

## 📊 Project Structure

```
gaming-portfolio/
├── README.md (this file)
├── project-1-spaceshoot/
│   ├── README.md (game-specific setup)
│   ├── Source/
│   ├── Assets/
│   └── Build/
├── project-2-running/
│   ├── README.md (game-specific setup)
│   ├── Source/
│   ├── Assets/
│   └── Build/
└── project-3-okla/
    ├── README.md (game-specific setup)
    ├── Source/
    ├── Assets/
    └── Build/
```

---

## 💡 Learning & Growth

This portfolio demonstrates progression across multiple dimensions:

- **Mechanics Complexity:** From item collection (OKLA) → score-based action (Space Shoot) → physics-based progression (Running)
- **Visual Fidelity:** Increasing animation complexity and visual polish
- **Technical Scope:** Expanding from 2D single-screen gameplay to 3D with procedural systems
- **User Experience:** Evolution of menus, settings, and accessibility features
- **Audio Integration:** From basic sound effects to state-aware music systems

---

## 🔧 Technologies Used

- **Game Engine:** [Your Engine Here - Unity/Godot/Custom]
- **Graphics:** [2D/3D Graphics Framework]
- **Audio:** [Audio Engine/Library]
- **Language:** [C#/GDScript/C++]
- **Art Tools:** [Aseprite/Photoshop/Krita for sprites, Blender for 3D assets]

---

## 📧 Contact & Links

- **GitHub:** https://github.com/AyanKan04
- **Email:** ayatokan5@gmail.com
- **Phone:** 0776692399

---

## 📝 License

These projects are shared for portfolio and educational purposes. Please refer to individual project folders for specific license information.

---

## 🙏 Acknowledgments

Special thanks to:
- The game development community for inspiration and resources
- Open-source tools and libraries that supported development
- Friends and testers who provided valuable feedback during development

---

**Last Updated:** March 2026

*Made with passion and countless hours of learning 🎮✨*

---

---

---

## Phiên Bản Tiếng Việt

# 🎮 Danh Sách Game Portfolio

Một bộ sưu tập các dự án game indie thể hiện các cơ chế gameplay đa dạng, tác phẩm nghệ thuật gốc và các nguyên lý thiết kế game. Mỗi game minh họa những thách thức kỹ thuật khác nhau và các giải pháp sáng tạo trong phát triển game.

---

## 📋 Mục Lục

- [Tổng Quan](#tổng-quan)
- [Các Game](#các-game)
  - [Space Shoot](#space-shoot-1)
  - [Running](#running-1)
  - [OKLA](#okla-1)
- [Điểm Nổi Bật Kỹ Thuật](#điểm-nổi-bật-kỹ-thuật)
- [Nghệ Thuật & Thiết Kế](#nghệ-thuật--thiết-kế)
- [Bắt Đầu](#bắt-đầu)
- [Liên Hệ](#liên-hệ)

---

## 🎯 Tổng Quan

Portfolio này thể hiện sự tiến bộ trong phát triển game, từ các cơ chế nền tảng (OKLA) đến các hệ thống phức tạp hơn (Running) và gameplay hành động được tinh chỉnh (Space Shoot). Mỗi dự án nhấn mạnh:

- **Tác phẩm nghệ thuật và hoạt ảnh gốc** — được vẽ tay bởi nhà phát triển
- **Cảm giác game được đánh bóng** — điều khiển phản hồi, thị giác và tích hợp âm thanh
- **Trải nghiệm người dùng** — menu trực quan, cài đặt và luồng game
- **Chất lượng code** — kiến trúc sạch hỗ trợ vòng lặp gameplay và mở rộng nội dung

---

## 🕹️ Các Game

### 🚀 Space Shoot

**Trạng Thái:** Demo | **Nền Tảng:** PC

Một trò chơi bắn không gian tốc độ cao, nơi người chơi điều khiển một chiếc máy bay chiến đấu chống lại các làn sóng tàu chiến ngoài hành tinh. Game kết hợp các cơ chế hành động với tiến trình thông qua các cấp độ có cấu trúc và một cuộc đối đầu Boss thách thức.

#### Các Tính Năng Gameplay:
- **Cơ Chế Lõi:** Hành động bắn-em-up với chuyển động có hướng và bắn liên tục
- **Đa Dạng Kẻ Thù:** Nhiều loại tàu chiến với hành vi khác nhau và rơi loot
- **Hệ Thống Tiến Độ:** 3 cấp độ (2 chuẩn + 1 cấp độ Boss) với độ khó tăng dần
- **Hệ Thống Item:** Thu thập power-up và tiêu hao trong chiến đấu để có lợi thế chiến thuật
- **Hệ Thống Điểm:** Kiếm điểm bằng cách loại bỏ kẻ thù, tranh tài cao điểm

#### Các Tính Năng Game:
- **Tạm Dừng/Tiếp Tục:** Tạm dừng gameplay hoàn toàn với lớp phủ UI
- **Hệ Thống Menu:** Điều hướng giữa các chế độ chơi, cài đặt và thoát
- **Cài Đặt Âm Thanh:** Kiểm soát âm lượng độc lập cho nhạc và hiệu ứng âm thanh (SFX)
- **Vòng Lặp Game:** Chơi liên tục với chức năng khởi động lại

#### Điểm Nổi Bật Kỹ Thuật:
- Kiến trúc chuyên sự kiện để tạo sóng kẻ thù
- Phát hiện va chạm cho đạn, item và nguy hiểm
- Khuôn khổ UI hỗ trợ nhiều menu và trạng thái
- Hệ thống quản lý âm thanh để thiết kế âm thanh động

#### Nghệ Thuật & Hình Ảnh:
- **100% Vẽ Tay:** Tất cả tác phẩm nghệ thuật, sprite và hoạt ảnh được tạo bởi nhà phát triển
- Thẩm mỹ pixel-art hoặc vector phong cách (tùy thuộc vào cách triển khai)
- Sprite ký tự động với nhiều khung hướng
- Hiệu ứng hình ảnh cho va chạm, nổ tung và nhặt power-up

**Kho Lưu Trữ:** [Space Shoot](./project-1-spaceshoot/)

---

### 🏃 Running

**Trạng Thái:** Demo | **Nền Tảng:** Mobile & PC (3D)

Một trò chơi chạy vô tận với một nhân vật bánh xe lăn tránh các môi trường đầy thách thức được tạo ra theo thủ tục. Game cân bằng các cơ chế lõi đơn giản với độ sâu thông qua các hệ thống tiến độ và thiết kế thách thức dựa trên vật lý.

#### Các Chế Độ Gameplay:

**Chế Độ Câu Chuyện (Dựa trên Cấp Độ):**
- 5 cấp độ được tuyển chọn với tỷ lệ khó tăng dần
- Bố cục chướng ngại vật được chế tạo thủ công và nhịp điệu
- Hệ thống điểm kiểm tra cho tiến độ

**Chế Độ Vô Tận (Arcade):**
- Tạo địa hình thủ tục vô hạn
- Tăng tốc liên tục dựa trên thời gian game và động lượng vật lý
- Cơ chế permadeath với hệ thống hồi sinh

#### Cơ Chế Lõi:
- **Chuyển Động Dựa Trên Vật Lý:** Bánh xe lăn tự nhiên với tăng tốc độ dựa trên quán tính
- **Đa Dạng Chướng Ngại:** Nhiều loại nguy hiểm yêu cầu các chiến lược né tránh khác nhau
- **Vật Phẩm Có Thể Thu Thập:** Xu vàng rải rác trong các cấp độ để tạo tiền tệ và ghi điểm
- **Power-up:** Các tăng cường tạm thời (tăng tốc, bảo vệ khiên) ảnh hưởng đến gameplay

#### Hệ Thống Tiến Độ:
- **Hệ Thống Tiền Tệ:** Thu thập xu để mở khóa hồi sinh ở chế độ vô tận
- **Cơ Chế Hồi Sinh:** Dùng xu để tiếp tục sau va chạm thay vì kết thúc game
- **Tỷ Lệ Khó:** Chướng ngại tăng về tần suất và độ phức tạp theo thời gian

#### Các Tính Năng Game:
- **Hệ Thống Menu:** Điều hướng giữa chế độ câu chuyện, chế độ vô tận và cài đặt
- **Tạm Dừng/Tiếp Tục:** Tạm dừng gameplay bất kỳ lúc nào
- **Cài Đặt Âm Thanh:** Kiểm soát âm lượng cho nhạc nền và hiệu ứng âm thanh
- **Vòng Lặp Game:** Chuyển đổi liền mạch giữa các cấp độ và khởi động lại chế độ

#### Điểm Nổi Bật Kỹ Thuật:
- Tích hợp động cơ vật lý 3D (động lực bánh xe và va chạm)
- Tạo cấp độ thủ tục cho đa dạng chế độ vô tận
- Tối ưu hóa hiệu suất cho gameplay liên tục
- Quản lý trạng thái trên các chế độ game khác nhau

#### Nghệ Thuật & Hình Ảnh:
- **Môi Trường 3D Tùy Chỉnh:** Bản đồ được thiết kế thủ công và tài sản tòa nhà cho cấp độ câu chuyện
- **Tích Hợp Tài Sản:** Các mô hình 3D chuyên nghiệp cho chướng ngại cơ sở và địa hình
- **Đánh Bóng Hình Ảnh:** Hiệu ứng hạt cho thu thập xu, va chạm và trầy xước
- **Thiết Kế HUD:** Giao diện sạch hiển thị điểm, bộ hẹn giờ và tiền tệ

**Kho Lưu Trữ:** [Running](./project-2-running/)

---

### 🪙 OKLA

**Trạng Thái:** Dự Án Demo Đầu Tiên | **Nền Tảng:** PC

Một trò chơi casual nền tảng được thiết kế như một điểm vào phát triển game. Người chơi điều khiển một ký tự để thu thập các vật phẩm rơi trong giới hạn thời gian, cân bằng rủi ro so với phần thưởng với các vật phẩm tích cực và tiêu cực hỗn hợp.

#### Gameplay:
- **Mục Tiêu:** Tối đa hóa điểm bằng cách thu thập các vật phẩm có lợi trước khi bộ hẹn giờ hết thời gian
- **Điều Khiển Ký Tự:** Chuyển động 2D đơn giản (trái/phải hoặc hướng 360 độ)
- **Đa Dạng Item:** Nhiều loại item với các hiệu ứng khác nhau:
  - **Tích Cực:** Xu, nhặt sức khỏe, tăng tốc
  - **Tiêu Cực:** Chướng ngại, nguy hiểm, vật phẩm phạt
- **Áp Lực Thời Gian:** Bộ hẹn giờ đếm ngược tạo sự khẩn cấp và thách thức

#### Thiết Kế Game:
- **Công Cụ Học Tập:** Dự án game hoàn chỉnh đầu tiên minh họa vòng lặp gameplay lõi
- **Cơ Chế Đơn Giản:** Dễ học, hỗ trợ các kiểu gameplay đa dạng
- **Phản Hồi Hấp Dẫn:** Tín hiệu hình ảnh và âm thanh để thu thập vật phẩm
- **Hệ Thống Điểm Cao:** Theo dõi hiệu suất tốt nhất trên các phiên

#### Nền Tảng Kỹ Thuật:
- Quản lý trạng thái cơ bản (menu, gameplay, game over)
- Phát hiện va chạm để nhặt vật phẩm
- Các hệ thống tạo và pooling đối tượng
- UI đơn giản cho menu và hiển thị trò chơi

#### Nghệ Thuật & Hình Ảnh:
- **Ký Tự Vẽ Tay:** Thiết kế sprite tùy chỉnh với hoạt ảnh nhàn rỗi và chuyển động
- **Sprite Item:** Thiết kế hình ảnh riêng biệt cho vật phẩm có thể thu thập và nguy hiểm
- **Hiệu Ứng Hạt:** Phản hồi hình ảnh để thu thập và va chạm
- **UI Sạch:** Menu đơn giản, dễ đọc và lớp phủ game

**Kho Lưu Trữ:** [OKLA](./project-3-okla/)

---

## 🎨 Điểm Nổi Bật Kỹ Thuật

### Các Thực Hành Phát Triển Chung

#### Đồ Họa & Hoạt Ảnh:
- **Tác Phẩm Nghệ Thuật 100% Vẽ Tay:** Tất cả sprite nhân vật và tài sản hình ảnh được tạo từ đầu
- **Hoạt Ảnh Tùy Chỉnh:** Hoạt ảnh từng khung hình cho ký tự, kẻ thù và hiệu ứng
- **Hướng Dẫn Nghệ Thuật:** Phong cách hình ảnh nhất quán được duy trì trên tất cả các game

#### Hệ Thống Âm Thanh:
- **Tích Hợp Nhạc:** Các vòng lặp nền hỗ trợ thay đổi trạng thái game
- **Hiệu Ứng Âm Thanh:** Âm thanh ngữ cảnh cho các tương tác (thu thập, va chạm, UI)
- **Quản Lý Âm Lượng:** Cài đặt âm thanh có thể truy cập của người dùng với các slider nhạc/SFX độc lập

#### Kiến Trúc Game:
- **Quản Lý Trạng Thái:** Tách biệt sạch giữa menu, gameplay và trạng thái tạm dừng
- **Xử Lý Đầu Vào:** Sơ đồ điều khiển phản hồi (bàn phím/gamepad tương thích)
- **Hệ Thống Sự Kiện:** Giao tiếp không ghép nối giữa các hệ thống game
- **Quản Lý Cảnh:** Tải và gỡ nội dung game hiệu quả

#### Trải Nghiệm Người Dùng:
- **UI Trực Quan:** Điều hướng rõ ràng thông qua menu và cài đặt
- **Chức Năng Tạm Dừng:** Tạm dừng gameplay toàn bộ với trạng thái có thể tiếp tục
- **Tính Bền Vững Cài Đặt:** Tùy chọn người dùng được lưu giữa các phiên
- **Hệ Thống Phản Hồi:** Tín hiệu hình ảnh và âm thanh cho tất cả các tương tác người chơi

### Tạo Tài Sản & 3D (Cụ Thể cho Running):
- **Nền Tảng 3D:** Sử dụng tài sản động cơ 3D tiêu chuẩn (địa hình, chướng ngại, vật lý)
- **Thiết Kế Cấp Độ Tùy Chỉnh:** Bố cục môi trường được chế tạo thủ công cho chế độ câu chuyện
- **Hệ Thống Bổ Sung Thủ Tục:** Tạo động hỗ trợ đa dạng chế độ vô tận
- **Kỹ Thuật Tối Ưu Hóa:** Hiển thị và quản lý bộ nhớ hiệu quả cho phát lại liên tục

---

## 🎯 Nghệ Thuật & Thiết Kế

### Quá Trình Sáng Tạo

Mỗi yếu tố hình ảnh trên các game này—từ sprite ký tự đến chi tiết môi trường—đại diện cho tác phẩm nghệ thuật tùy chỉnh được tạo trong quá trình phát triển:

**Thiết Kế Ký Tự:**
- Khái niệm ký tự gốc với nhận dạng hình ảnh riêng biệt
- Nhiều khung hoạt ảnh cho chuyển động và hành động
- Giao tiếp hình ảnh biểu cảm của trạng thái gameplay

**Môi Trường & UI:**
- Tác phẩm nghệ thuật nền tảng tùy chỉnh và chi tiết môi trường
- Thiết kế giao diện được đặt tên phù hợp với thẩm mỹ game
- Hiệu ứng hình ảnh (hạt, chuyển đổi) tăng cường cảm giác game

**Game Running (Cụ Thể 3D):**
- Các yếu tố hỗ trợ được tạo ra theo thủ tục được xây dựng trên tài sản 3D tiêu chuẩn
- Thiết kế kiến trúc tùy chỉnh cho môi trường chế độ câu chuyện
- Ngôn ngữ hình ảnh kết dính trên các lớp 3D và UI

### Triết Học Thiết Kế

- **Sự Rõ Ràng Hình Ảnh:** Sprite và UI dễ đọc hỗ trợ gameplay ngay lập tức
- **Tích Hợp Phản Hồi:** Tín hiệu hình ảnh tăng cường hành động và hậu quả của người chơi
- **Cân Bằng Hiệu Suất:** Tham vọng nghệ thuật được ôn hòa bởi tối ưu hóa thời gian chạy
- **Khả Năng Tiếp Cận:** Bảng màu thân thiện với người mù màu và thiết kế độ tương phản cao (nếu có)

---

## 🚀 Bắt Đầu

### Điều Kiện Tiên Quyết:
- **Space Shoot & OKLA:** Game engine với hỗ trợ hiển thị 2D (ví dụ: Unity, Godot)
- **Running:** Game engine 3D (ví dụ: Unity 3D, Unreal Engine)
- Kiến thức cơ bản về nền tảng đã chọn

### Cài Đặt:

Mỗi thư mục game chứa:
- Mã nguồn hoàn chỉnh
- Tài sản (sprite, âm thanh, tập tin dữ liệu)
- Cấu hình xây dựng cho nền tảng của bạn
- README với hướng dẫn thiết lập

**Để chơi một game:**
1. Điều hướng đến thư mục dự án
2. Làm theo hướng dẫn `README.md` của game riêng lẻ cho các bước xây dựng dành riêng cho nền tảng
3. Chạy game và tận hưởng!

### Phát Triển:

Mỗi dự án được cấu trúc để dễ dàng mở rộng nội dung:
- **Thiết Kế Cấp Độ:** Thêm cấp độ mới bằng cách tạo tệp dữ liệu cấp độ
- **Điều Chỉnh Cân Bằng:** Tùy chỉnh các tham số game trong tệp cấu hình
- **Thay Thế Tài Sản:** Thay thế liền mạch tài sản nghệ thuật và âm thanh
- **Mở Rộng Tính Năng:** Mã được tổ chức tốt hỗ trợ các cơ chế mới

---

## 📊 Cấu Trúc Dự Án

```
gaming-portfolio/
├── README.md (tệp này)
├── project-1-spaceshoot/
│   ├── README.md (thiết lập dành riêng cho game)
│   ├── Source/
│   ├── Assets/
│   └── Build/
├── project-2-running/
│   ├── README.md (thiết lập dành riêng cho game)
│   ├── Source/
│   ├── Assets/
│   └── Build/
└── project-3-okla/
    ├── README.md (thiết lập dành riêng cho game)
    ├── Source/
    ├── Assets/
    └── Build/
```

---

## 💡 Học Tập & Tăng Trưởng

Portfolio này thể hiện tiến bộ trên nhiều chiều:

- **Độ Phức Tạp Của Cơ Chế:** Từ bộ sưu tập vật phẩm (OKLA) → hành động dựa trên điểm (Space Shoot) → tiến độ dựa trên vật lý (Running)
- **Độ Trung Thực Hình Ảnh:** Tăng độ phức tạp hoạt ảnh và đánh bóng hình ảnh
- **Phạm Vi Kỹ Thuật:** Mở rộng từ gameplay 2D trên màn hình đơn đến 3D với hệ thống thủ tục
- **Trải Nghiệm Người Dùng:** Sự tiến hóa của menu, cài đặt và các tính năng khả năng tiếp cận
- **Tích Hợp Âm Thanh:** Từ hiệu ứng âm thanh cơ bản đến hệ thống nhạc nhận biết trạng thái

---

## 🔧 Công Nghệ Sử Dụng

- **Game Engine:** [Your Engine Here - Unity/Godot/Custom]
- **Đồ Họa:** [Khung Đồ Họa 2D/3D]
- **Âm Thanh:** [Engine/Thư Viện Âm Thanh]
- **Ngôn Ngữ:** [C#/GDScript/C++]
- **Công Cụ Nghệ Thuật:** [Aseprite/Photoshop/Krita cho sprite, Blender cho tài sản 3D]

---

## 📧 Liên Hệ & Liên Kết

- **GitHub:** https://github.com/AyanKan04
- **Email:** ayatokan5@gmail.com
- **Phone:** 0776692399

---

## 📝 Giấy Phép

Những dự án này được chia sẻ cho mục đích danh mục đầu tư và giáo dục. Vui lòng tham khảo các thư mục dự án riêng lẻ để biết thông tin giấy phép cụ thể.

---

## 🙏 Lời Cảm Ơn

Cảm ơn đặc biệt:
- Cộng đồng phát triển game để lấy cảm hứng và tài nguyên
- Công cụ mã nguồn mở và thư viện hỗ trợ phát triển
- Bạn bè và những người test đã cung cấp phản hồi quý báu trong quá trình phát triển

---

**Cập Nhật Lần Cuối:** Tháng 3 năm 2026

*Được tạo bằng đam mê và vô số giờ học tập 🎮✨*
