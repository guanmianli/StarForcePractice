## StarForcePractice 简介

StarForcePractice是一个对[StarForce](https://github.com/EllanJiang/StarForce)的Copy练习项目，主要目的是学会Game Framework框架的使用，下面是一些个人的学习记录。

---

## 准备工作

### 项目搭建

+ 本地创建一个名为`StarForcePractice`项目并添加README.md文件作为学习笔记。

![image-20200623104123214](README.assets/image001.png)

+ `Github`创建一个同名仓库，不勾选`README`初始化，因为我们上面已经创建了

![image-20200623104809361](README.assets/image-20200623104809361.png)

+ 使用`git init`命令将本地项目初始化为Git版本库

![image-20200623105225639](README.assets/image-20200623105225639.png)

+ 将本地仓库与远程仓库关联

![image-20200623105658038](README.assets/image-20200623105658038.png)

+ 使用`git add .`和 `git commit -m"首次提交"`命令进行首次提交。
+ 使用`git push -u origin master`将本地仓库所有内容推送到远程仓库。

---

### 项目资源与框架导入

+ 创建`GameFramework`文件夹并将框架导入到该文件夹中。
  ![image-20200623140951161](README.assets/image-20200623140951161.png)
+ 创建`GameMain`文件夹，打开`StarForce`项目将项目中用到资源都拉到我们的项目中来。

![image-20200623141955442](README.assets/image-20200623141955442.png)

OK，到此项目所有准备工作就完成了，就下来就开始开发了~

---

## 开发

### 场景搭建

#### :small_blue_diamond:初识内置模块

+ 在场景中创建空物体`Game Framework`，将框架中的`GameFramework`预制体拖放到该空物体下。

![image-20200623145153211](README.assets/image-20200623145153211.png)

1.我们可以看到该预制体下面有很多子物体，这些就是GF框架为我们提供的内置模块。
2.每个子物体上都挂载了以`Component`结尾的脚本，它们的底层自然就是继承了`MonoBehaviour`，我们后面就将这些内置模块称为组件。

> GF对很多游戏开发常用模块进行了封装，很大程度地规范开发过程、加快开发速度并保证产品质量。

+ 既然有内置组件，那么框架肯定也为我们提供了创建自定义组件的接口，只需要继承自框架的`GameFrameworkComponent`类。
+ 在`Game Framework`父节点下在创建一个空物体`Customs`用于存放我们的自定义组件，然后将预制体名字修改为`Built-in`意思是内置的组件。

![image-20200623145802689](README.assets/image-20200623145802689.png)



#### 场景灯光与照明设置

+ 删除掉场景中自带的`Directional Light`平行光。
+ `Window>Rendering>Lighting Settings` 打开照明设置窗口，关闭掉天空盒与环境照明。

![image-20200623154511265](README.assets/image-20200623154511265.png)



#### 场景相机设置

+ 命名为`Camera`，重置`Transform`，清除`Tag`设置，设置背景色为纯黑色。
+ 设置相机的渲染内容`Culling Mask`为`Nothing`，缩小相机的可视范围`Clipping Planes`，取消勾选`HDR`。