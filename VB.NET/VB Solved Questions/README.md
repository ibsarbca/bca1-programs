# Some notes regarding the applications in these folders

* Console Applications and simple Forms applications are not included.

* MDF files for the databases are not included. As such, the connection string will have to be changed accordingly in the applications and the schemas will have to be derived from the questions. However, since the applications follow the schemas as described in the questions, this should not be too difficult.

* BindingNavigator is used in several questions, especially those that simply require add/update/delete/insert operations. This is because the questions don't explicitly say that BindingNavigator should not be used and it should be legal in the examination. However, not all applications use a simple BindingNavigator.

* Connected and Disconnected architectures are used fairly randomly. This is so that there is enough practice for both methods. 

* Typed datasets are not used because it is uncertain whether or not they are allowed.

* Simple Forms questions are not repeated, especially ones that use a PicutreBox with a timer.

* Some common programs are included in the "Common" folder

* The code is often redundant and repeats in several places where it shouldn't. This is done for the sake of practice, but primarily in the interest of time. It should be noted that doing so is not considered good practice and can lead to several problems later like making debugging and updating much harder. Try Catch is also not used where it should be for the same reasons.
