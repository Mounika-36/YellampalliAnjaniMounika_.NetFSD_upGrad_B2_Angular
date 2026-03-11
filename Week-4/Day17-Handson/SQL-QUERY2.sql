-- Problem 2: Atomic Order Cancellation with SAVEPOINT

-- Stored Procedure for Order Cancellation 

CREATE PROCEDURE CancelOrder
@order_id INT
AS
BEGIN

BEGIN TRY

BEGIN TRANSACTION

-- Savepoint
SAVE TRANSACTION BeforeStockRestore

-- Restore stock
UPDATE s
SET s.quantity = s.quantity + oi.quantity
FROM stocks s
JOIN order_items oi
ON s.product_id = oi.product_id
WHERE oi.order_id = @order_id

-- Update order status to Rejected (3)
UPDATE orders
SET order_status = 3
WHERE order_id = @order_id

COMMIT TRANSACTION

PRINT 'Order cancelled successfully'

END TRY

BEGIN CATCH

    ROLLBACK TRANSACTION BeforeStockRestore

    PRINT 'Error occurred. Rolling back to savepoint.'

END CATCH

END