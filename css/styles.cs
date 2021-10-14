@import url("https://cdn.jsdelivr.net/gh/orioncactus/pretendard/dist/web/variable/pretendardvariable.css");
:root {
  --textColor1: #008cff;
  --textColor2: #fff;
  --textColor3: #737594; }

@media screen and (min-width: 320px) {
  html {
    width: 100%; } }

body {
  background-color: #eee9e2;
  font-family: Pretendard, -apple-system, BlinkMacSystemFont, system-ui, Roboto, 'Helvetica Neue', 'Segoe UI', 'Apple SD Gothic Neo', 'Noto Sans KR', 'Malgun Gothic', sans-serif !important;
  margin: 0px !important;
  overflow: hidden;
  width: 100%;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

html, body {
  max-width: 100%;
  overflow-x: hidden; }

p {
  line-height: 154%; }

#app {
  height: 100%;
  display: flex;
  flex-direction: column;
  align-content: center;
  align-items: center;
  justify-content: center; }
  @media screen and (min-width: 450px) {
    #app {
      width: 450px; } }
  @media screen and (max-width: 450px) {
    #app {
      width: 100%; } }

.fadeInUpReady {
  visibility: hidden; }

/*container size*/
.container {
  width: 100%;
  height: 300px; }
  .container.border {
    border: 1px solid black; }
  .container.video {
    height: 182px;
    width: 324px;
    background-color: #1f1f1f; }
    .container.video div {
      display: flex;
      justify-content: center;
      align-items: center;
      align-content: center;
      width: 100%;
      height: 100%; }
      .container.video div div:nth-child(1) {
        background-color: #eee9e2; }
  .container#mainVideo {
    height: 790px; }
  .container#uniminiTitle {
    height: 700px; }
    .container#uniminiTitle .deco {
      position: relative;
      bottom: 275px;
      display: flex;
      justify-content: space-between; }
  .container#universityMap {
    background-color: black;
    height: 800px; }
    .container#universityMap .movingLine {
      height: 220px; }
  .container#unizone {
    height: 200px;
    text-align: right; }
  .container#mingle {
    height: 400px; }
  .container#videos {
    height: 844px;
    background-color: black; }
  .container#description {
    height: 366px; }

.mainTitleDeco {
  background-color: black;
  height: 40px;
  border-radius: 25px; }
  .mainTitleDeco#left {
    width: 50px;
    transform: translate(-90%, 0); }
  .mainTitleDeco#right {
    width: 300px;
    transform: translate(180px, 0); }

.movingLine {
  height: 70px;
  width: 100%;
  position: relative;
  top: 75px; }
  .movingLine .line img {
    height: 30px;
    margin-bottom: 10px; }

#phoneMockUp img {
  position: relative;
  float: right;
  top: 2px;
  border-top-left-radius: 20px; }
  @media screen and (min-width: 390px) {
    #phoneMockUp img {
      width: 366px; } }

#animation-2 {
  width: 200px;
  height: 46px;
  position: relative;
  top: 5px; }
  #animation-2:after {
    position: absolute;
    content: "";
    top: 0;
    left: 0;
    width: 0;
    height: 100%;
    border-top-right-radius: 20px;
    border-bottom-right-radius: 20px;
    background: #07c083;
    transition: all .35s; }
  #animation-2:hover {
    color: #fff; }
    #animation-2:hover:after {
      width: 100%; }
  #animation-2 span {
    position: absolute;
    left: 24px;
    z-index: 2; }

#animation-1 {
  width: 200px;
  height: 46px;
  position: relative;
  top: 5px;
  float: right; }
  #animation-1:after {
    position: absolute;
    content: "";
    top: 0;
    right: 0;
    width: 0;
    height: 100%;
    border-top-left-radius: 20px;
    border-bottom-left-radius: 20px;
    background: #07c083;
    transition: all .35s; }
  #animation-1:hover {
    color: #fff; }
    #animation-1:hover:after {
      width: 100%; }
  #animation-1 span {
    position: absolute;
    right: 24px;
    z-index: 2; }

/*text*/
span.highlighted {
  color: #07c083; }

span.size12 {
  font-size: 12px; }

span.size13 {
  font-size: 13px; }

span.size14 {
  font-size: 14px; }

span.size16 {
  font-size: 16px; }

span.size36 {
  font-size: 36px; }

span.light {
  font-weight: 300; }

span.mid {
  font-weight: 600; }

span.bold {
  font-weight: bold; }

span.grey {
  color: #636363; }

span.white {
  color: white; }

span.center {
  text-align: center; }

.title {
  margin-left: 20px;
  font-size: 30px; }
  .title.big {
    margin-left: 15px;
    font-size: 60px; }

.description {
  margin-left: 20px;
  font-size: 13px; }

/*fixed icon*/
#smallButtonJoinBeta {
  width: 70px;
  height: 70px;
  position: fixed;
  right: 8%;
  bottom: -10%;
  background-color: #07c083;
  border-radius: 35px;
  border: none;
  z-index: 9999;
  transition: bottom .2s; }
  #smallButtonJoinBeta.show {
    bottom: 5%; }

#smallButtonJoinBeta div.icon {
  position: relative;
  top: 10px;
  left: 4px;
  width: 0px;
  height: 0px;
  border-left: 8px solid transparent;
  border-right: 8px solid transparent;
  border-top: 12px solid white; }

#smallButtonJoinBeta div.text {
  position: relative;
  top: 25px;
  right: 36px;
  width: 100px;
  font-size: 12px; }

/*footer*/
#bigButtonJoinBeta {
  position: relative;
  left: 50%;
  transform: translate(-50%, 0%);
  width: 300px;
  height: 50px;
  background-color: #eee9e2;
  color: #07c083;
  font-size: 18px;
  text-align: center;
  border-radius: 15px;
  border: 2px solid #07c083;
  color: var(--textColor2);
  background-image: linear-gradient(90deg, #07c083, #078cc0, #075dc0, #0065ff, #0033ff, #0065ff, #075dc0, #078cc0, #07c083);
  background-size: 400%;
  background-position: 0% 0%; }
  #bigButtonJoinBeta::before {
    content: '';
    position: absolute;
    left: -2px;
    top: -2px;
    right: -2px;
    bottom: -2px;
    border-radius: 26px;
    background-image: linear-gradient(90deg, #07c083, #078cc0, #075dc0, #0065ff, #0033ff, #0065ff, #075dc0, #078cc0, #07c083);
    background-size: 500%;
    background-position: 0% 0%;
    filter: blur(10px);
    opacity: 0;
    z-index: -1;
    transition: opacity 0.2s; }
  #bigButtonJoinBeta:hover {
    animation: gradientRotate 2s infinite; }
    #bigButtonJoinBeta:hover::before {
      opacity: 1;
      animation: gradientRotate 2s infinite; }
  #bigButtonJoinBeta:active {
    color: #c3c4d5; }
  #bigButtonJoinBeta:focus::before {
    opacity: 1; }

@keyframes gradientRotate {
  0% {
    background-position: 0% 0%; }
  100% {
    background-position: 100% 100%; } }

#linkToInstagram {
  text-align: center;
  margin-top: 50px; }
  #linkToInstagram img {
    transform: translate(-20%, 30%); }
