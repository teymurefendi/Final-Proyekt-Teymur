function myBtnA() {
    var x = document.getElementById("respon-menu");
    var y = document.getElementById("container")
    
    if (x.className === "respon-menu") {
      x.className += " responsive";      
      y.style.height=(y.offsetHeight + 594) + "px";
    } else {
      x.className = "respon-menu";
      y.style.height=(y.offsetHeight - 594) + "px";      
    }
  }

  function myBtnSpan() {
    var x = document.getElementById("down");
    if (x.className === "down") {
      x.className += " responsive2";
    } else {
      x.className = "down";
    }
  }

  $(document).ready(function(){
    $("#icon-span").click(function(){
    var src = $(document.getElementById('icon-span').getElementsByTagName('img')).attr('src');
    var newsrc = (src=='dist/img/arrow-down.png') ? 'dist/img/arrow-up.png' : 'dist/img/arrow-down.png';
    $(document.getElementById('icon-span').getElementsByTagName('img')).attr('src', newsrc );
    });
});


let titles = document.getElementsByClassName("accordion-topic");
let contents = document.getElementsByClassName("accordion-content");

for (let i = 0; i < titles.length; i++) {
  titles[i].addEventListener("click", function(e) {

    for (let j = 0; j < titles.length; j++) {
      if (titles[j] != this) {
          titles[j].classList.remove("rotate")
      }
    }

  this.classList.toggle("rotate");

      for (let j = 0; j < contents.length; j++) {
          if (contents[j] != this.nextElementSibling) {
              contents[j].classList.remove("acc-active")
          }
      }

      this.nextElementSibling.classList.toggle("acc-active");
  })
}


var mybutton = document.getElementById("back-to-top");

//scroll daki functionlari bura yaz...
window.onscroll = function() {scrollFunction(),myFunction()};

function scrollFunction() {
  if (document.body.scrollTop > 200 || document.documentElement.scrollTop > 200) {
    mybutton.style.opacity = "1";
  } else {
    mybutton.style.opacity = "0";
  }
}
$(document).ready(function(){
 var Mybutton =$('#back-to-top')
  Mybutton.on('click', function(e) {
    e.preventDefault();
    $('html, body').delay(100).animate({scrollTop:0}, '300');  
  });
});

// window.onscroll = function() {myFunction()};

var header = document.getElementById("myMainHeader");
var sticky = header.offsetTop;

function myFunction() {
  if (window.pageYOffset > sticky) {
    header.classList.add("sticky");
  } else {
    header.classList.remove("sticky");
  }
}

// window.onscroll= function scrollPhoto(){
//   var qaqawPhoto=document.getElementById("#photo-of-qaqaw")
//   document.body.scrollHeight=qaqawPhoto.scrollHeight;
// };

const scrollElements = document.querySelectorAll(".js-scroll");

const elementInView = (el, dividend = 1) => {
  const elementTop = el.getBoundingClientRect().top;

  return (
    elementTop <=
    (window.innerHeight || document.documentElement.clientHeight) / dividend
  );
};

const elementOutofView = (el) => {
  const elementTop = el.getBoundingClientRect().top;

  return (
    elementTop > (window.innerHeight || document.documentElement.clientHeight)
  );
};

const displayScrollElement = (element) => {
  element.classList.add("scrolled");
};

const hideScrollElement = (element) => {
  element.classList.remove("scrolled");
};

const handleScrollAnimation = () => {
  scrollElements.forEach((el) => {
    if (elementInView(el, 1.25)) {
      displayScrollElement(el);
    } else if (elementOutofView(el)) {
      hideScrollElement(el)
    }
  })
}

window.addEventListener("scroll", () => { 
  handleScrollAnimation();
});

var women = document.getElementById("raptor");
var btns = women.getElementsByClassName("raptor-li");
var li1 = document.getElementById("li-1");
var li2 = document.getElementById("li-2");
var li3 = document.getElementById("li-3");
var current = document.getElementsByClassName(" active2");
for (var i = 0; i < btns.length; i++) {  
  btns[i].addEventListener("click", function(e) {
  e.preventDefault();
  var krakadil = document.getElementsByClassName(" active3"); 
 
  krakadil[0].className -= " active3";
  
  
  current[0].className -= " active2";
  
  this.className += " active2"; 
  if (current[0].getAttribute("data-form")===li1.getAttribute("data-type")) {
        li1.className += " active3"
        li2.className = "li-content"
        li3.className = "li-content"
      }
      else{
        if (current[0].getAttribute("data-form")===li2.getAttribute("data-type")) {
          li2.className += " active3"
          li1.className = "li-content"
          li3.className = "li-content"      
        }
        else{
          if (current[0].getAttribute("data-form")===li3.getAttribute("data-type")) {
            li3.className += " active3" 
            li2.className = "li-content"
            li1.className = "li-content"       
          }      
        }
      }
  console.log(current[0].getAttribute("data-form"))
  });
}

let countUp = (countItems) => {
  for (let i = 0; i < countItems.length; i++) {

      let j = 0;
      let step = Number(document.getElementsByClassName("counter")[i].dataset.step);
      let speed = Number(document.getElementsByClassName("counter")[i].dataset.speed);
      let myNumber = Number(document.getElementsByClassName("counter")[i].dataset.number);

      let startCount = (number) => {
          if (j >= number) {
              clearInterval(myInterval);
          }

          j += step;
          if (j > number) {
              j = number;
          }
          countItems[i].innerHTML = j;
      }

      let myInterval = setInterval(function() {
          startCount(myNumber);
      }, speed);
  }
}


window.addEventListener("scroll", function() {
  let counterItem = document.querySelectorAll("#what-we-did .counter");
  if (document.documentElement.scrollTop < 2000) {
      for (let i = 0; i < counterItem.length; i++) {
          counterItem[i].innerHTML = 0;
      }
  }

  if (Number(counterItem[0].innerText) == 0) {
      if (document.documentElement.scrollTop >= 2500) {
          countUp(counterItem);
      }
  }
});

window.addEventListener("scroll", function() {
  let counterItem = document.querySelectorAll("#years .counter");
  if (document.documentElement.scrollTop < 500) {
      for (let i = 0; i < counterItem.length; i++) {
          counterItem[i].innerHTML = 0;
      }
  }

  if (Number(counterItem[0].innerText) == 0) {
      if (document.documentElement.scrollHeight >= 1500) {
          countUp(counterItem);
      }
  }
});

window.addEventListener("scroll", function() {
  let counterItem = document.querySelectorAll("#basqail .counter");
  if (document.documentElement.scrollTop < 500) {
      for (let i = 0; i < counterItem.length; i++) {
          counterItem[i].innerHTML = 0;
      }
  }

  if (Number(counterItem[0].innerText) == 0) {
      if (document.documentElement.scrollHeight >= 1500) {
          countUp(counterItem);
      }
  }
});



$(document).ready(function () {
  $('.testimonial-long').slick({
      slidesToShow: 3,
      slidesToScroll: 1,
      arrows: false,
      infinite: true,      
      dots: true,
      responsive: [
        {
          breakpoint: 991,
          settings: {
            slidesToShow: 2,
            slidesToScroll: 1,
            infinite: true,
            dots: true
          }
        },
        {
          breakpoint: 776,
          settings: {
            slidesToShow: 1,
            slidesToScroll: 1
          }
        }
       
        // You can unslick at a given breakpoint now by adding:
        // settings: "unslick"
        // instead of a settings object
      ]
    });

    var dotNums = document.querySelectorAll(".slick-dots button");

  function removeText(item) {
    item.innerHTML = ""; // or put the text you need inside quotes
  }

  dotNums.forEach(removeText);
  });
    

  // var submitButton = document.getElementById('form-valid');
  // submitButton.addEventListener("submit", function(e){
  //   e.preventDefault(e);
  //   console.log("wdjolwd");
  //   var email = document.getElementById('email').value;
  //   var phone = document.getElementById('phone').value;
  //   var name = document.getElementById('name').value;        
  //   var message = document.getElementById('message').value;        
  //   var error = document.getElementById('submit-error');        
  //   var success = document.getElementById('submit-success');        
  //   var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;  
  //   if (!emailPattern.test(email)) {
  //       error.style.display = "unset";
  //   }
  //   if (phone == null || phone == "" || name == null || name == "" || message == null || message == "") {
  //     error.style.display = "unset";   
  //   }
  //   else{
  //     success.style.display = "unset";
  //   }
  // });


function likebtn() {
  var x = document.getElementById("urek");
  var y = document.getElementById("like-count")
  var z = parseInt(y.innerHTML);
  if (x.className === "far fa-heart") {
    x.className = "fas fa-heart";
    x.style.color="red";
    y.innerHTML = (z+1).toString();    
  } else {
    x.className = "far fa-heart";
    x.style.color = "#999";
    y.innerHTML = (z-1).toString(); 
  }
}

function rtlltr() {
  var changer = document.getElementsByTagName("body")[0];
  if (changer.className == "") {
    changer.className = "direction-rtl";
  }
  if (changer.className == "direction-ltr") {
    changer.className = "direction-rtl";
  }
  else{
    changer.className = "direction-ltr";
  }
};





  

   


