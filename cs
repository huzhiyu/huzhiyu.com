<!DOCTYPE html>
<html lang="en">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1"/>
        <meta http-equiv="Expires" content="0">
        <meta http-equiv="Pragma" content="no-cache">
        <meta http-equiv="Cache-control" content="no-cache">
        <meta http-equiv="Cache" content="no-cache">
        <meta http-equiv="X-UA-Compatible" content="IE=9"/>
        <meta name="renderer" content="webkit"/>
        <meta charset="UTF-8"/>
        <script src="//cdn.bootcss.com/jquery/1.11.0/jquery.js"></script>
    </head>
    <body>
        <script>
            document.getElementById("img").height=document.documentElement.clientHeight-65;
            $.ajax({
                type:'GET',
                url:'https://api.weixin.qq.com/cgi-bin/token',
                data:{"grant_type":"client_credential","appid":"wxca129b09db17bb21","secret":"393e3333b4fb21b7f7c4eb4b2c2a1008"},
                cache:false,
                dataType:'json'
                success:function(data){
                    if( data.expires_in !="" ){
                        alert(1);
                    }else{
                        alert(2);
                    }
                },
                error:function(){}
            });
        </script>
    </body>
</html>
