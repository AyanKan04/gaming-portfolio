🚀 Space Shooter

Genre: 2D Arcade Space Shooter (Shoot 'em up)
Platform: PC
Engine: Unity
Language: C#
Status: Demo

Space Shooter là một game bắn tàu vũ trụ 2D theo phong cách arcade, nơi người chơi điều khiển một chiến đấu cơ để chiến đấu với các làn sóng tàu chiến ngoài hành tinh. Người chơi cần né tránh đạn, tiêu diệt kẻ địch và thu thập vật phẩm để đạt điểm số cao nhất.

Game được phát triển nhằm luyện tập gameplay programming, hệ thống spawn enemy, collision detection, và quản lý trạng thái game trong Unity.

🎮 Gameplay Overview

Người chơi điều khiển một fighter jet và chiến đấu với các enemy waves xuất hiện liên tục.

Mục tiêu chính:

Tiêu diệt kẻ địch

Thu thập vật phẩm hỗ trợ

Tăng điểm số

Vượt qua các level và đánh bại boss

Game có 3 level với độ khó tăng dần:

Level 1: Enemy waves cơ bản

Level 2: Enemy mạnh hơn và spawn nhanh hơn

Level 3: Boss battle với lượng máu lớn và tấn công mạnh

🕹 Core Gameplay Mechanics
Player Control

Điều khiển phi thuyền bằng directional movement

Hệ thống continuous shooting cho phép bắn liên tục

Tránh đạn và va chạm với enemy

Combat System

Người chơi bắn đạn để tiêu diệt kẻ địch

Enemy có nhiều loại với hành vi khác nhau

Boss có máu lớn và pattern tấn công riêng

Enemy System

Enemy spawn theo wave system

Một số enemy có khả năng:

di chuyển nhanh

bắn đạn

thả vật phẩm

⭐ Game Systems
Item & Power-up System

Trong quá trình chiến đấu, enemy có thể rơi vật phẩm:

Power-ups: tăng sức mạnh tấn công

Consumables: hỗ trợ người chơi trong combat

Score System

Người chơi nhận điểm khi:

tiêu diệt enemy

hoàn thành level

Hệ thống này khuyến khích đạt high score.

Level Progression

Game gồm:

2 level thường

1 boss level

Độ khó tăng dần theo từng level.

🖥 Game Features
Menu System

Start Game

Settings

Quit Game

Pause System

Người chơi có thể:

tạm dừng game

tiếp tục chơi

Audio Settings

Cho phép điều chỉnh:

Music volume

Sound effects (SFX)

Game Loop

Sau khi game kết thúc, người chơi có thể:

restart game

chơi lại để đạt điểm cao hơn

⚙ Technical Implementation

Game được phát triển để luyện tập các kỹ thuật lập trình game trong Unity.

Event-driven Enemy Spawning

Enemy spawn dựa trên wave events thay vì spawn ngẫu nhiên.

Collision Detection

Hệ thống xử lý va chạm cho:

bullets

enemies

player

collectible items

UI Management System

Hệ thống UI quản lý nhiều trạng thái game:

main menu

pause menu

gameplay UI

Audio Management

Hệ thống quản lý:

background music

sound effects

🎨 Art & Visual Design

Tất cả assets trong game được tự thiết kế và vẽ thủ công.

Bao gồm:

spaceship sprites

enemy ships

bullet effects

explosion animations

item icons

Phong cách đồ họa:

2D arcade style

sprite animation cho chuyển động

hiệu ứng va chạm và explosion

📂 Project Structure

cấu trúc thư mục trong Unity:

Assets
├── Audio
├── Materials
├── Prefabs
├── Scenes
├── Scripts
├── Sprites
└── TextMesh Pro

Các script chính:

PlayerController

EnemySpawner

BulletSystem

GameManager

UIManager

▶ Demo

Gameplay demo:https://drive.google.com/file/d/1rm_4GQo0hT02bwPTrbLrfTYKUNlhmcsE/view?usp=drive_link
