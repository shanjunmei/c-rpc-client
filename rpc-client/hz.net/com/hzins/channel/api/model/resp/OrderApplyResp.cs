/**
 * Copyright (c) 2006-2015 Hzins Ltd. All Rights Reserved. 
 *  
 * This code is the confidential and proprietary information of   
 * Hzins. You shall not disclose such Confidential Information   
 * and shall use it only in accordance with the terms of the agreements   
 * you entered into with Hzins,http://www.hzins.com.
 *  
 */   


using System.Collections.Generic;

using com.hzins.channel.api.model.info;
using com.hzins.channel.api.model.info;

namespace  com.hzins.channel.api.model.resp{
/**
 * <p>
 * 
 * </p>
 * @author	hz15031081 
 * @date	2015-4-13 下午7:56:26
 * @version      
 */
public class OrderApplyResp {
    
    private string transNo;
    
    // 代理商信息
    private int partnerId;  
    
    // 惠择投保单号
    private string insureNum;
    
    // 保单信息
    private IList<OrderInfo> orderInfos;
    
    //保单与被保人关联信息
    IList<OrderExtInfo> orderExts;

    
    
    
    
    
    public virtual IList<OrderExtInfo> getOrderExts() {
        return orderExts;
    }


    
    public virtual void setOrderExts(IList<OrderExtInfo> orderExts) {
        this.orderExts = orderExts;
    }


    public virtual string getTransNo() {
        return transNo;
    }

    
    public virtual void setTransNo(string transNo) {
        this.transNo = transNo;
    }

   
    public virtual int getPartnerId() {
        return partnerId;
    }
    
    public virtual void setPartnerId(int partnerId) {
        this.partnerId = partnerId;
    }
    

    public virtual string getInsureNum() {
        return insureNum;
    }


    
    public virtual void setInsureNum(string insureNum) {
        this.insureNum = insureNum;
    }


    public  virtual IList<OrderInfo> getOrderInfos() {
        return orderInfos;
    }
    
    public virtual void setOrderInfos(IList<OrderInfo> orderInfos) {
        this.orderInfos = orderInfos;
    }

}
 }